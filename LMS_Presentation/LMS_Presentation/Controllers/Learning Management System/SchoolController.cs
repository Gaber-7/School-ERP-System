using AutoMapper;
using LMS_Business_Layer.DTO.School_DTO;
using LMS_Data_Access_Layer.IUnitOfWorkfolder.UnitOfWork;
using LMS_Data_Access_Layer.IUnitOfWorkFolder.Interface;
using LMS_Data_Access_Layer.Models.Learning_Management_System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Presentation_Layer.Controllers.Learning_Management_System
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public SchoolController(IUnitOfWork unitOfWork, IMapper mapping)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapping;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var schools = await unitOfWork.Schools_Repository.Select_All_With_IncludesById(s => s.IsDeleted != true);
            if (schools == null || schools.Count == 0)
            {
                return NotFound("No schools found.");
            }

            List<School_GetDTO> schoolDTO = mapper.Map<List<School_GetDTO>>(schools);
            return Ok(schoolDTO);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(long id)
        {
            if (id == 0)
            {
                return NotFound("School with ID not found.");
            }
            School school = unitOfWork.Schools_Repository.First_Or_Default(s => s.ID == id && s.IsDeleted != true);
            if (school == null || school.IsDeleted == true)
            {
                return NotFound($"School with ID {id} not found.");
            }
            School_GetDTO schoolDTO = mapper.Map<School_GetDTO>(school);
            return Ok(schoolDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] School_AddDTO newSchool)
        {

            if (newSchool == null)
            {
                return BadRequest("Invalid school data.");
            }
            if (newSchool.Name == null)
            {
                return BadRequest("the name cannot be null");
            }

            var School = mapper.Map<School>(newSchool);
            School school = mapper.Map<School>(newSchool);


            unitOfWork.Schools_Repository.Add(School);
            await unitOfWork.Schools_Repository.SaveChangesAsync();
            return Ok(newSchool);

        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] School_GetDTO newSchool)
        {
            if (newSchool == null)
            {
                return BadRequest("Invalid school data.");
            }
            if (newSchool.Name == null)
            {
                return BadRequest("the name cannot be null");
            }
            School school = unitOfWork.Schools_Repository.First_Or_Default(s => s.ID == newSchool.ID && s.IsDeleted != true);
            if (school == null || school.IsDeleted == true)
            {
                return NotFound($"School with ID {newSchool.ID} not found.");
            }
            mapper.Map(newSchool, school);
            unitOfWork.Schools_Repository.Update(school);
            await unitOfWork.Schools_Repository.SaveChangesAsync();
            return Ok(newSchool);
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            if (id == 0)
            {
                return BadRequest("id cannot be null");
            }

          //  var school =  unitOfWork.Schools_Repository.First_Or_Default(School => School.ID == id && School.IsDeleted != true);
            School school = unitOfWork.Schools_Repository.Select_By_Id(id);
            if (school == null || school.IsDeleted == true)
            {
                return NotFound($"School with ID {id} not found.");
            }
            school.IsDeleted = true;
            unitOfWork.Schools_Repository.Update(school);
            await unitOfWork.Schools_Repository.SaveChangesAsync();
            return Ok(school);
        }
    }
}
