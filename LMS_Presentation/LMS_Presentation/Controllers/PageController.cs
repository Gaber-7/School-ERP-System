using AutoMapper;
using LMS_Business_Layer.DTO.Page_DTO;
using LMS_Data_Access_Layer.IUnitOfWorkFolder.Interface;
using LMS_Data_Access_Layer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace LMS_Presentation_Layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageController : ControllerBase 
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;


        public PageController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {   
            var pages = unitOfWork.Page_Repository.FindBy(x => x.IsActive && x.IsDisplay).ToList();

            if (pages == null || !pages.Any())
                return NotFound("No pages found.");

            List<Page_Get_DTO> pagesDTO = mapper.Map<List<Page_Get_DTO>>(pages);

            var hierarchicalPages = BuildHierarchy(pagesDTO, null);

            return Ok(hierarchicalPages);
        }

        private List<Page_Get_DTO> BuildHierarchy(List<Page_Get_DTO> pages,long? parentId)
        {
            var children = pages.Where(x => x.Page_ID == parentId).OrderBy(x => x.Order).ToList();

            foreach (var child in children)
            {
                child.Children = BuildHierarchy(pages, child.ID);
            }

            return children;
        }
    }
}
