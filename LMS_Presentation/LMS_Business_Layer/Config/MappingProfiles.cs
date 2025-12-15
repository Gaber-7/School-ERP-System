using AutoMapper;
using LMS_Business_Layer.DTO.DepartmentDTO;
using LMS_Data_Access_Layer.Models.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Business_Layer.Config
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // Employee Mappings
            CreateMap<Department_Get_DTO, Department>().ReverseMap();



            // Department Mappings
            CreateMap<Department, Department_Get_DTO>().ReverseMap();
            CreateMap<Department_Add_DTO, Department>().ReverseMap();
            CreateMap<Department_Get_DTO, Department>().ReverseMap();


            // Academic Year Mappings

        }
    }
}
