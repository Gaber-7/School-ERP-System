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
        //[HttpPost]
        //public async Task<IActionResult> Add([FromBody] AcademicYear_Add_DTO NewacademicYear_Add_DTO)
        //{

        //   if (NewacademicYear_Add_DTO == null)
        //        return BadRequest("AcademicYear cannot be null");
           
        //   if (NewacademicYear_Add_DTO.Name == null)
        //        return BadRequest("the name cannot be null");
           
        //   School school =  unitOfWork.Schools_Repository.First_Or_Default(s => s.ID == NewacademicYear_Add_DTO.SchoolID && s.IsDeleted != true);

        //   if (school == null)
        //   { 
        //    return NotFound($"School with ID {NewacademicYear_Add_DTO.SchoolID} not found.");
        //   }
        //    AcademicYear academicYear = mapper.Map<AcademicYear>(NewacademicYear_Add_DTO);


        //    List<AcademicYear> academicYears =  unitOfWork.AcademicYears_Repository.FindBy(
        //        ay => ay.SchoolID == NewacademicYear_Add_DTO.SchoolID && ay.IsDeleted != true);

        //}
    }
}