using AutoMapper;
using LMS_Business_Layer.DTO.Grade_DTO;
using LMS_Data_Access_Layer.IUnitOfWorkFolder.Interface;
using LMS_Data_Access_Layer.Models.Administration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMS_Presentation_Layer.Controllers.Administration
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GradeController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {

            List<Grade> grades = await unitOfWork.Grades_Repository.Select_All_With_IncludesById(
               grade => grade.IsDeleted != true,
                     query => query.Include(grade => grade.Section));

            if (!grades.Any())
            {
                return NotFound("No Grades found.");
            }

            List<Grade_Get_DTO> grade_Get_DTOs = mapper.Map<List<Grade_Get_DTO>>(grades);
            return Ok(grade_Get_DTOs);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromForm]Grade_Add_DTO grade_Add_DTO)
        {
            if (grade_Add_DTO == null)
                return BadRequest("Grade data is null."); 
           
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (grade_Add_DTO.SectionID == null)
            {
                return BadRequest("section id can not be null");
            }

            if (grade_Add_DTO.Name == null)
                return BadRequest("Grade Name is required.");
       
            Section section = await unitOfWork.Sections_Repository.FindByIncludesAsync(sec => sec.ID == grade_Add_DTO.SectionID && sec.IsDeleted != true,
                query => query.Include(emp => emp.school));

            if (section == null)
                return NotFound($"Section with ID {grade_Add_DTO.SectionID} not found.");

            if (grade_Add_DTO.SAT != null)
            {
                if (section.school.MaximumPeriodCountTimeTable == null)
                {
                    return BadRequest("School hasn't set Maximum Period Count Time Table.");
                }
                if (grade_Add_DTO.SAT > section.school.MaximumPeriodCountTimeTable)
                {
                    return BadRequest($"SAT value cannot exceed the school's maximum period count time table of {section.school.MaximumPeriodCountTimeTable}.");
                }
            }

            if (grade_Add_DTO.SUN != null)
            {
                if (section.school.MaximumPeriodCountTimeTable == null)
                {
                    return BadRequest("School hasn't set Maximum Period Count Time Table.");
                }
                if (grade_Add_DTO.SUN > section.school.MaximumPeriodCountTimeTable)
                {
                    return BadRequest($"SAT value cannot exceed the school's maximum period count time table of {section.school.MaximumPeriodCountTimeTable}.");
                }
            }
            if (grade_Add_DTO.MON != null)
            {
                if (section.school.MaximumPeriodCountTimeTable == null)
                {
                    return BadRequest("School hasn't set Maximum Period Count Time Table.");
                }
                if (grade_Add_DTO.MON > section.school.MaximumPeriodCountTimeTable)
                {
                    return BadRequest($"SAT value cannot exceed the school's maximum period count time table of {section.school.MaximumPeriodCountTimeTable}.");
                }
            }
            if (grade_Add_DTO.TUS != null)
            {
                if (section.school.MaximumPeriodCountTimeTable == null)
                {
                    return BadRequest("School hasn't set Maximum Period Count Time Table.");
                }
                if (grade_Add_DTO.TUS > section.school.MaximumPeriodCountTimeTable)
                {
                    return BadRequest($"SAT value cannot exceed the school's maximum period count time table of {section.school.MaximumPeriodCountTimeTable}.");
                }
            }
            if (grade_Add_DTO.WED != null)
            {
                if (section.school.MaximumPeriodCountTimeTable == null)
                {
                    return BadRequest("School hasn't set Maximum Period Count Time Table.");
                }
                if (grade_Add_DTO.WED > section.school.MaximumPeriodCountTimeTable)
                {
                    return BadRequest($"SAT value cannot exceed the school's maximum period count time table of {section.school.MaximumPeriodCountTimeTable}.");
                }
            }
            if (grade_Add_DTO.THRU != null)
            {
                if (section.school.MaximumPeriodCountTimeTable == null)
                {
                    return BadRequest("School hasn't set Maximum Period Count Time Table.");
                }
                if (grade_Add_DTO.THRU > section.school.MaximumPeriodCountTimeTable)
                {
                    return BadRequest($"SAT value cannot exceed the school's maximum period count time table of {section.school.MaximumPeriodCountTimeTable}.");
                }
            }
            if (grade_Add_DTO.FRI != null)
            {
                if (section.school.MaximumPeriodCountTimeTable == null)
                {
                    return BadRequest("School hasn't set Maximum Period Count Time Table.");
                }
                if (grade_Add_DTO.FRI > section.school.MaximumPeriodCountTimeTable)
                {
                    return BadRequest($"SAT value cannot exceed the school's maximum period count time table of {section.school.MaximumPeriodCountTimeTable}.");
                }
            }


            Grade grade = mapper.Map<Grade>(grade_Add_DTO);

            await unitOfWork.Grades_Repository.AddAsync(grade);
            await unitOfWork.Grades_Repository.SaveChangesAsync();
            return Ok(grade_Add_DTO);

        }
    }
}