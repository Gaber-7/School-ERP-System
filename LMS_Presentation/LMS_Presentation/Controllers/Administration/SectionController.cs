using AutoMapper;
using LMS_Business_Layer.DTO.SectionDTO;
using LMS_Data_Access_Layer.IUnitOfWorkFolder.Interface;
using LMS_Data_Access_Layer.Models.Administration;
using LMS_Data_Access_Layer.Models.Learning_Management_System;
using LMS_Presentation_Layer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMS_Presentation_Layer.Controllers.Administration
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public SectionController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        [Authorize(Policy = Permissions.Section.View)]
        public async Task<IActionResult> GetAsync()
        {

            List<Section> sections = await unitOfWork.Sections_Repository.Select_All_With_IncludesById(
               sec => sec.IsDeleted != true,
                     query => query.Include(emp => emp.school));

            if (!sections.Any())
            {
                return NotFound("No Sections found.");
            }

            List<Section_GetDTO> section_GetDTOs = mapper.Map<List<Section_GetDTO>>(sections);
            return Ok(section_GetDTOs);
        }

        [HttpGet("{id}")]
        [Authorize(Policy = Permissions.Section.View)]
        public async Task<IActionResult> GetByIdAsync(long id)
        {
            if (id == 0)
                return NotFound("Section with ID not found.");


            var section = await unitOfWork.Sections_Repository.FindByIncludesAsync(
                em => em.IsDeleted != true && em.ID == id,
                query => query.Include(e => e.school));

            if (section == null)
                return NotFound($"Section with ID {id} not found.");

            Section_GetDTO section_GetDTO = mapper.Map<Section_GetDTO>(section);

            return Ok(section_GetDTO);
        }

        [HttpPost]
        [Authorize(Policy = Permissions.Section.Create)]
        public async Task<IActionResult> PostAsync([FromForm] Section_AddDTO section_AddDTO)
        {
            if (section_AddDTO == null)
            {
                return BadRequest("Section data is null.");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (section_AddDTO.Name == null)
            {
                return BadRequest("the name cannot be null");
            }

            School school = await unitOfWork.Schools_Repository.FindByIncludesAsync(s => s.IsDeleted != true && s.ID == section_AddDTO.SchoolID);

            if (school == null)
            {
                return NotFound($"School with ID {section_AddDTO.SchoolID} not found.");
            }

            Section section = mapper.Map<Section>(section_AddDTO);

            unitOfWork.Sections_Repository.Add(section);
            unitOfWork.Sections_Repository.SaveChanges();
            return Ok(section_AddDTO);
        }

        [HttpPut]
        [Authorize(Policy = Permissions.Section.Edit)]
        public IActionResult PutAsync([FromForm] Section_EditDTO section_EditDTO)
        {
            if (section_EditDTO == null)
                return BadRequest("Section data is null.");
            if (!ModelState.IsValid)
                return BadRequest(ModelState); 
            if (section_EditDTO.Name == null)
                return BadRequest("the name cannot be null");


            Section section = unitOfWork.Sections_Repository.First_Or_Default(s => s.ID == section_EditDTO.ID && s.IsDeleted != true);
            if (section == null)
                return NotFound($"Section with ID {section_EditDTO.ID} not found.");

            School school = unitOfWork.Schools_Repository.First_Or_Default(s => s.ID == section_EditDTO.SchoolID && s.IsDeleted != true);
            if (school == null)
                return NotFound($"School with ID {section_EditDTO.SchoolID} not found.");

            mapper.Map(section_EditDTO, section);
            unitOfWork.Sections_Repository.Update(section);
            unitOfWork.Sections_Repository.SaveChanges();
            return Ok(section_EditDTO);
        }


        [HttpDelete("{id}")]
        [Authorize(Policy = Permissions.Section.Delete)]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            if (id == 0)
                return NotFound("Section with ID not found.");

        //    var section1 =  unitOfWork.Sections_Repository.First_Or_Default(s => s.ID == id);
            Section section = unitOfWork.Sections_Repository.Select_By_Id(id);

            if (section == null)
                return NotFound($"Section with ID {id} not found.");

            section.IsDeleted = true;
            unitOfWork.Sections_Repository.SaveChanges();
            return Ok($"Section with ID {id} has been deleted.");
        }
    }
}
