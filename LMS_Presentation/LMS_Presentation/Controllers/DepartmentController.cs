using AutoMapper;
using LMS_Business_Layer.DTO.DepartmentDTO;
using LMS_Data_Access_Layer.IUnitOfWorkFolder.Interface;
using LMS_Data_Access_Layer.Models.Administration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace LMS_Presentation_Layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public DepartmentController(IUnitOfWork unitOfWork, IMapper mapping)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapping;
        }

        [HttpGet]
        [Authorize(Policy = "Department.View")]
        public async Task<IActionResult> GetAsync()
        {
            var departments = await unitOfWork.Departmentes_Repository.Select_All_With_IncludesById(d => d.IsDeleted != true);
            if (departments == null || departments.Count == 0)
            {
                return NotFound("No departments found.");
            }
            List<Department_Get_DTO> departmentsDTO = mapper.Map<List<Department_Get_DTO>>(departments);
            return Ok(departmentsDTO);
        }

        [HttpGet("{id}")]
        [Authorize(Policy = "Department.View")]
        public async Task<IActionResult> GetByIdAsync(long id)
        {
            Department department = unitOfWork.Departmentes_Repository.First_Or_Default(
                d => d.ID == id && d.IsDeleted != true);
            if (department == null)
                {
                return NotFound($"Department with ID {id} not found.");
            }
            Department_Get_DTO departmentDTO = mapper.Map<Department_Get_DTO>(department);
            return Ok(departmentDTO);

        }
        [HttpPost]
        [Authorize(Policy = "Department.Create")]
        public async Task<IActionResult> Add([FromBody] Department_Add_DTO department_Add_DTO)
        {
            
            if (department_Add_DTO == null)
            {
                return BadRequest("Department cannot be null");
            }

            Department department = mapper.Map<Department>(department_Add_DTO);

            unitOfWork.Departmentes_Repository.Add(department);
            await unitOfWork.Departmentes_Repository.SaveChangesAsync();

            return Ok(department_Add_DTO);

        }
        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] Department_Get_DTO department_Get_DTO)
        {
            if (department_Get_DTO == null)
            {
                return BadRequest("Department cannot be null");
            }

            Department department = unitOfWork.Departmentes_Repository.First_Or_Default(
                d => d.ID == department_Get_DTO.ID && d.IsDeleted != true);

            if (department == null)
            { 
                return NotFound($"Department with ID {department_Get_DTO.ID} not found.");
            }

            mapper.Map(department_Get_DTO, department);
            unitOfWork.Departmentes_Repository.Update(department);
            await unitOfWork.Departmentes_Repository.SaveChangesAsync();
            return Ok(department_Get_DTO);
        }

        [HttpDelete("{id}")]
        [Authorize(Policy = "Employee.Delete")]
        public  IActionResult Delete(long id)
        {
            if (id == 0)
            { 
                return NotFound("Department with ID not found.");
            }
            Department department =  unitOfWork.Departmentes_Repository.First_Or_Default(
                d => d.ID == id && d.IsDeleted != true);

            
            if (department == null)
            {
                return BadRequest();
            }

            department.IsDeleted = true;
            unitOfWork.Departmentes_Repository.Update(department);
            unitOfWork.Departmentes_Repository.SaveChanges();
            return Ok(department);

        }
    }
}