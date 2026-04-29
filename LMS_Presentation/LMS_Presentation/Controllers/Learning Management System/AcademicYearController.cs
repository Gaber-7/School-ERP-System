using AutoMapper;
using LMS_Business_Layer.DTO.AcademicYearDTO;
using LMS_Data_Access_Layer.IUnitOfWorkfolder.UnitOfWork;
using LMS_Data_Access_Layer.IUnitOfWorkFolder.Interface;
using LMS_Data_Access_Layer.Models.Learning_Management_System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMS_Presentation_Layer.Controllers.Learning_Management_System
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademicYearController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public AcademicYearController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            List<AcademicYear> academicYear = await unitOfWork.AcademicYears_Repository.Select_All_With_IncludesById(
             sem => sem.IsDeleted != true,
              query => query.Include(emp => emp.School));

            if (academicYear == null || academicYear.Count == 0)
            {
                return NotFound("No Academic Years found.");
            }

            List<AcademicYear_Get_DTO> academicYear_Get_DTOs = mapper.Map<List<AcademicYear_Get_DTO>>(academicYear);

            return Ok(academicYear_Get_DTOs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(long id)
        {
            if (id == 0)
            {
                return NotFound("Academic Year with ID not found.");
            }

            var academicYear = await unitOfWork.AcademicYears_Repository.FindByIncludesAsync(
                em => em.IsDeleted != true && em.ID == id,
                query => query.Include(e => e.School));

            if (academicYear == null)
            {
                return NotFound($"Academic Year with ID {id} not found.");
            }

            AcademicYear_Get_DTO academicYear_Get_DTO = mapper.Map<AcademicYear_Get_DTO>(academicYear);
            return Ok(academicYear_Get_DTO);


        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AcademicYear_Add_DTO NewacademicYear_Add_DTO)
        {

            if (NewacademicYear_Add_DTO == null)
                return BadRequest("AcademicYear cannot be null");

            if (NewacademicYear_Add_DTO.Name == null)
                return BadRequest("the name cannot be null");

            School school = unitOfWork.Schools_Repository.First_Or_Default(s => s.ID == NewacademicYear_Add_DTO.SchoolID && s.IsDeleted != true);

            if (school == null)
            {
                return NotFound($"School with ID {NewacademicYear_Add_DTO.SchoolID} not found.");
            }
            AcademicYear academicYear = mapper.Map<AcademicYear>(NewacademicYear_Add_DTO);

            if (NewacademicYear_Add_DTO.DateFrom > NewacademicYear_Add_DTO.DateTo)
                return BadRequest("Invalid date range");

            if (academicYear.IsActive == true)
            {
                List<AcademicYear> activeAcademicYears = unitOfWork.AcademicYears_Repository.FindBy(a => a.schoolId == NewacademicYear_Add_DTO.SchoolID && a.IsDeleted != true);
                foreach (var activeAcademicYear in activeAcademicYears)
                {
                    activeAcademicYear.IsActive = false;
                }
            }

            unitOfWork.AcademicYears_Repository.Add(academicYear);
            await unitOfWork.AcademicYears_Repository.SaveChangesAsync();
            return Ok(NewacademicYear_Add_DTO);

        }
        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] AcademicYear_Get_DTO academicYear_Get_DTO)
        {
            if (academicYear_Get_DTO == null)
                return BadRequest("Academic Year cannot be null");

            if (academicYear_Get_DTO.Name == null)
                return BadRequest("the name cannot be null");

            School school = unitOfWork.Schools_Repository.First_Or_Default(s => s.ID == academicYear_Get_DTO.SchoolId && s.IsDeleted != true);
            if (school == null)
            {
                return NotFound($"School with ID {academicYear_Get_DTO.SchoolId} not found.");
            }

            AcademicYear existingAcademicYear = unitOfWork.AcademicYears_Repository.First_Or_Default(a => a.ID == academicYear_Get_DTO.ID && a.IsDeleted != true);

            if (existingAcademicYear == null)
                return NotFound($"Academic Year with ID {academicYear_Get_DTO.ID} not found.");

            if (academicYear_Get_DTO.DateFrom > academicYear_Get_DTO.DateTo)
                return BadRequest("Invalid date range");

            if (academicYear_Get_DTO.IsActive == true)
            {
                List<AcademicYear> activeAcademicYears = unitOfWork.AcademicYears_Repository.FindBy(a => a.schoolId == academicYear_Get_DTO.SchoolId && a.IsDeleted != true);
                foreach (var activeAcademicYear in activeAcademicYears)
                {
                    activeAcademicYear.IsActive = false;
                }
            }
            mapper.Map(academicYear_Get_DTO, existingAcademicYear);
            await unitOfWork.AcademicYears_Repository.SaveChangesAsync();
            return Ok(academicYear_Get_DTO);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            if (id == 0)
                return NotFound("Academic Year with ID not found.");

            AcademicYear existingAcademicYear = unitOfWork.AcademicYears_Repository.First_Or_Default(a => a.ID == id && a.IsDeleted != true);

            if (existingAcademicYear == null)
                return NotFound($"Academic Year with ID {id} not found.");

            existingAcademicYear.IsDeleted = true;
            await unitOfWork.AcademicYears_Repository.SaveChangesAsync();
            return Ok();


        }
    }
}