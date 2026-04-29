using AutoMapper;
using LMS_Data_Access_Layer.IUnitOfWorkFolder.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Presentation_Layer.Controllers.Administration
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;    
        private readonly IMapper mapper;

        public GradeController(IUnitOfWork unitOfWork , IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

    }
}
