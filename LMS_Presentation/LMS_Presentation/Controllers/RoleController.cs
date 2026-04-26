using AutoMapper;
using LMS_Business_Layer.DTO.RolesDTO;
using LMS_Data_Access_Layer.IUnitOfWorkFolder.Interface;
using LMS_Data_Access_Layer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace LMS_Presentation_Layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public RoleController(IUnitOfWork unitOfWork , IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
          List<Role> roles = await unitOfWork.Roles_Repository.Select_All_With_IncludesById(
             sem => sem.IsDeleted != true);

            if (roles == null || roles.Count == 0)
            {
                return NotFound();
            }

            List<RolesGetDTO> RolesDTO = mapper.Map<List<RolesGetDTO>>(roles);
            return Ok(roles);
        }

    }
}
 