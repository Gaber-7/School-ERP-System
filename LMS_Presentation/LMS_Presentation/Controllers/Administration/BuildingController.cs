using AutoMapper;
using LMS_Business_Layer.DTO.BuildingDTO;
using LMS_Data_Access_Layer.IUnitOfWorkfolder.UnitOfWork;
using LMS_Data_Access_Layer.IUnitOfWorkFolder.Interface;
using LMS_Data_Access_Layer.Models.Administration;
using LMS_Data_Access_Layer.Models.Learning_Management_System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMS_Presentation_Layer.Controllers.Administration
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public BuildingController(IUnitOfWork unitOfWork, IMapper mapping)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapping;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {

            List<Building> buildings = await unitOfWork.Buildings_Repository.Select_All_With_IncludesById(
                b => b.IsDeleted != true,
                query => query.Include(emp => emp.school));

            if (buildings == null || buildings.Count == 0)
            {
                return NotFound("No buildings found.");
            }
            List<Building_Get_DTO> buildingsDTO = mapper.Map<List<Building_Get_DTO>>(buildings);
            return Ok(buildingsDTO);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(long id)
        {
            if (id == 0)
            {
                return NotFound("Building with ID not found.");
            }

            Building building = await unitOfWork.Buildings_Repository.FindByIncludesAsync(
                t => t.IsDeleted != true && t.ID == id,
                query => query.Include(e => e.school));

            if (building == null)
            {
                return NotFound($"Building with ID {id} not found.");
            }

            Building_Get_DTO buildingDTO = mapper.Map<Building_Get_DTO>(building);
            return Ok(buildingDTO);
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Building_Add_DTO NewBuilding)
        {
            if (NewBuilding == null)
            {
                return BadRequest("Building cannot be null");
            }
            if (NewBuilding.Name == null)
            {
                return BadRequest("the name cannot be null");
            }

            if (NewBuilding.SchoolID != 0)
            {
                School school = unitOfWork.Schools_Repository.First_Or_Default(s => s.ID == NewBuilding.SchoolID && s.IsDeleted != true);
                if (school == null)
                {
                    return BadRequest("No School with this ID");
                }
            }

            Building building = mapper.Map<Building>(NewBuilding);
            unitOfWork.Buildings_Repository.Add(building);
            await unitOfWork.Buildings_Repository.SaveChangesAsync();

            return Ok(NewBuilding);
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] Building_Get_DTO building_Get_DTO)
        {
            if (building_Get_DTO == null)
            {
                return BadRequest("Building cannot be null");
            }
            if (building_Get_DTO.Name == null)
            {
                return BadRequest("the name cannot be null");
            }
            Building existingBuilding = unitOfWork.Buildings_Repository.First_Or_Default(b => b.ID == building_Get_DTO.ID && b.IsDeleted != true);
            if (existingBuilding == null)
            {
                return NotFound($"Building with ID {building_Get_DTO.ID} not found.");
            }
            if (building_Get_DTO.SchoolID != 0)
            {
                School school = unitOfWork.Schools_Repository.First_Or_Default(s => s.ID == building_Get_DTO.SchoolID && s.IsDeleted != true);
                if (school == null)
                {
                    return BadRequest("No School with this ID");
                }
            }
            //existingBuilding.Name = building_Get_DTO.Name;
            //existingBuilding.SchoolID = building_Get_DTO.SchoolID;
            mapper.Map(building_Get_DTO, existingBuilding);

            unitOfWork.Buildings_Repository.Update(existingBuilding);
            await unitOfWork.Buildings_Repository.SaveChangesAsync();
            return Ok(building_Get_DTO);


        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            if (id == 0)
            {
                return NotFound("Building with ID not found.");
            }
            Building building = unitOfWork.Buildings_Repository.First_Or_Default(b => b.ID == id && b.IsDeleted != true);
            if (building == null)
            {
                return BadRequest();
            }
            building.IsDeleted = true;
            unitOfWork.Buildings_Repository.Update(building);
            unitOfWork.Buildings_Repository.SaveChanges();
            return Ok(building);


        }
    }
}
