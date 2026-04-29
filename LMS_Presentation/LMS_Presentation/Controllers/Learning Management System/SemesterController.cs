using AutoMapper;
using LMS_Business_Layer.DTO.Semester_DTO;
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
    public class SemesterController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public SemesterController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            List<Semester> semesters = await unitOfWork.Semesters_Repository.Select_All_With_IncludesById(

              sem => sem.IsDeleted != true,
                    query => query.Include(emp => emp.AcademicYear));

            if (!semesters.Any())
            {
                return NotFound("No Semesters found.");
            }

            List<Semester_Get_DTO> semester_Get_DTO = mapper.Map<List<Semester_Get_DTO>>(semesters);

            return Ok(semester_Get_DTO);

        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetByIdAsync(long id)
        {
            if (id == 0)
            {
                return NotFound("Semester with ID not found.");
            }

            var semester = await unitOfWork.Semesters_Repository.FindByIncludesAsync(
                em => em.IsDeleted != true && em.ID == id,
                query => query.Include(e => e.AcademicYear));
            if (semester == null)
            {
                return NotFound($"Semester with ID {id} not found.");
            }
            Semester_Get_DTO semester_Get_DTO = mapper.Map<Semester_Get_DTO>(semester);
            return Ok(semester_Get_DTO);
        }



        [HttpPost]
        public async Task<IActionResult> PostAsync([FromForm] Semester_Post_DTO semester_Post_DTO)
        {
            if (semester_Post_DTO == null)
                return BadRequest("Semester data is null.");

            if (semester_Post_DTO.Name == null)
                return BadRequest("the name cannot be null");

            AcademicYear academicYears = unitOfWork.AcademicYears_Repository.First_Or_Default(sem => sem.ID == semester_Post_DTO.AcademicYearID && sem.IsDeleted != true);

            if (academicYears == null)
                return NotFound($"Academic Year with ID {semester_Post_DTO.AcademicYearID} not found.");

            Semester semester = mapper.Map<Semester>(semester_Post_DTO);

            if (semester_Post_DTO.IsCurrent == true)
            {
                List<Semester> semesters1 = unitOfWork.Semesters_Repository.Select_All();
                foreach (var sem in semesters1)
                {
                    sem.IsCurrent = false;
                }
            }

            await unitOfWork.Semesters_Repository.AddAsync(semester);
            await unitOfWork.Buildings_Repository.SaveChangesAsync();
            return Ok(semester_Post_DTO);

        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromForm] SemesterEditDTO semesterEditDTO)
        {

            if (semesterEditDTO == null)
                return BadRequest("Semester data is null.");

            if (semesterEditDTO.Name == null)
                return BadRequest("the name cannot be null");

            AcademicYear academicYears = unitOfWork.AcademicYears_Repository.First_Or_Default(sem => sem.ID == semesterEditDTO.AcademicYearID && sem.IsDeleted != true);

            if (academicYears == null)
                return NotFound($"Academic Year with ID {semesterEditDTO.AcademicYearID} not found.");

            Semester semester = await unitOfWork.Semesters_Repository.FindByIncludesAsync(s => s.ID == semesterEditDTO.ID && s.IsDeleted != true);

            if (semester == null)
                {
                    return NotFound($"Semester with ID {semesterEditDTO.ID} not found.");
            }

             mapper.Map(semesterEditDTO, semester);

            if (semesterEditDTO.IsCurrent == true)
            {
                List<Semester> semesters1 = unitOfWork.Semesters_Repository.Select_All();
                foreach (var sem in semesters1)
                {
                    sem.IsCurrent = false;
                }
            }
            unitOfWork.Semesters_Repository.SaveChanges();
            return Ok(semesterEditDTO);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            if (id == 0)
            {
                return NotFound("Semester with ID not found.");
            }
            var semester = await unitOfWork.Semesters_Repository.FindByIncludesAsync(s => s.ID == id && s.IsDeleted != true);
            if (semester == null)
            {
                return NotFound($"Semester with ID {id} not found.");
            }
            semester.IsDeleted = true;
             unitOfWork.Semesters_Repository.SaveChanges();
            return Ok($"Semester with ID {id} has been deleted.");
        }
    }
}
