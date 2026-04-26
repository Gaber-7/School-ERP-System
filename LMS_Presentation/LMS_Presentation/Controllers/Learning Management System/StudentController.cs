using AutoMapper;
using LMS_Data_Access_Layer.IUnitOfWorkFolder.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Presentation_Layer.Controllers.Learning_Management_System
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public StudentController(IUnitOfWork unitOfWork , IMapper mapper) 
        {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
        
        }
    }
}
