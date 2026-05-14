using AutoMapper;
using LMS_Business_Layer.DTO.Floor_DTO;
using LMS_Data_Access_Layer.IUnitOfWorkFolder.Interface;
using LMS_Data_Access_Layer.Models;
using LMS_Data_Access_Layer.Models.Administration;
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
    public class FloorController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public FloorController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

        }
        [HttpGet]
        [Authorize(Policy = Permissions.Floor.View)]
        public async Task<IActionResult> GetAsync()
        {

            List<Floor> floors = await unitOfWork.Floors_Repository.Select_All_With_IncludesById(
                f => f.IsDeleted != true,
               query => query.Include(emp => emp.building),
               query => query.Include(emp => emp.floorMonitor));


            if (floors == null || floors.Count == 0)
            {
                return NotFound();
            }
            List<Floor_Get_DTO> floorDTO = mapper.Map<List<Floor_Get_DTO>>(floors);
            return Ok(floorDTO);
        }

        [HttpGet("{id}")]
        [Authorize(Policy = Permissions.Floor.View)]
        public async Task<IActionResult> GetByIdAsync(long id)
        {
            if (id == 0)
            {
                return NotFound("Floor with ID not found.");
            }

            Floor floor = await unitOfWork.Floors_Repository.FindByIncludesAsync(
                t => t.IsDeleted != true && t.ID == id,
                query => query.Include(e => e.building),
                query => query.Include(e => e.floorMonitor));

            if (floor == null)
                return NotFound();

            Floor_Get_DTO floorDTO = mapper.Map<Floor_Get_DTO>(floor);
            return Ok(floorDTO);
        }

        [HttpPost]
        [Authorize(Policy = Permissions.Floor.Create)]
        public async Task<IActionResult> Add([FromBody] Floor_Add_DTO NewFloor)
        {
            if (NewFloor == null)
            {
                return BadRequest("Floor cannot be null");
            }

            if (NewFloor.Name == null)
            {
                return BadRequest("the name cannot be null");
            }
            if (NewFloor.buildingID != 0)
            {
                Building building = unitOfWork.Buildings_Repository.First_Or_Default(b => b.ID == NewFloor.buildingID && b.IsDeleted != true);
                if (building == null)
                {
                    return NotFound($"Building with ID {NewFloor.buildingID} not found.");
                }
            }
            else
            {
                return BadRequest("Building ID cannot be zero");
            }

            if (NewFloor.FloorMonitorID != null)
            {
                Employee employee = unitOfWork.Employees_Repository.First_Or_Default(e => e.ID == NewFloor.FloorMonitorID && e.IsDeleted != true);
                if (employee == null)
                {
                    return NotFound($"Employee with ID {NewFloor.FloorMonitorID} not found.");
                }
            }

            Floor floor = mapper.Map<Floor>(NewFloor);
            unitOfWork.Floors_Repository.Add(floor);
            await unitOfWork.Floors_Repository.SaveChangesAsync();
            return Ok("Floor added successfully");
        }

        [HttpPut]
        [Authorize(Policy = Permissions.Floor.Edit)]
        public async Task<IActionResult> Update([FromBody] Floor_Update_DTO EditedFloor)
        {
            if (EditedFloor == null)
            {
                return BadRequest("Floor cannot be null");
            }

            if (EditedFloor.Name == null)
            {
                return BadRequest("the name cannot be null");
            }

            if (EditedFloor.buildingID != 0)
            {
                Building building = unitOfWork.Buildings_Repository.First_Or_Default(b => b.ID == EditedFloor.buildingID && b.IsDeleted != true);

                if (building == null)
                {
                    return NotFound($"Building with ID {EditedFloor.buildingID} not found.");
                }
            }
            else
            {
                return BadRequest("Building ID cannot be zero");
            }

            if (EditedFloor.FloorMonitorID != 0)
            {
                Employee employee = unitOfWork.Employees_Repository.First_Or_Default(e => e.ID == EditedFloor.FloorMonitorID && e.IsDeleted != true);

                if (employee == null)
                {
                    return NotFound($"Employee with ID {EditedFloor.FloorMonitorID} not found.");
                }
            }


            Floor floor = unitOfWork.Floors_Repository.Select_By_Id(EditedFloor.ID);

            if (floor == null || floor.IsDeleted == true)
            {
                return NotFound($"Floor with ID not found.");
            }

            mapper.Map(EditedFloor, floor);

            unitOfWork.Floors_Repository.Update(floor);
            await unitOfWork.Floors_Repository.SaveChangesAsync();
            return Ok("Floor updated successfully");

        }
        [HttpDelete("{id}")]
        [Authorize(Policy = Permissions.Floor.Delete)]
        public async Task<IActionResult> Delete(long id)
        {
            if (id == 0)
            {
                return NotFound("Floor with ID not found.");
            }

            Floor floor = unitOfWork.Floors_Repository.First_Or_Default(f => f.ID == id && f.IsDeleted != true);
            if (floor == null)
            {
                return NotFound($"Floor with ID not found.");
            }

            floor.IsDeleted = true;

            unitOfWork.Floors_Repository.Update(floor);
            await unitOfWork.Floors_Repository.SaveChangesAsync();
            return Ok("Floor deleted successfully");

        }
    }
}