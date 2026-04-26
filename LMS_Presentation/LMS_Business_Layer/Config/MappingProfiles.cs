using AutoMapper;
using LMS_Business_Layer.DTO.DepartmentDTO;
using LMS_Business_Layer.DTO.School_DTO;
using LMS_Data_Access_Layer.Models.Administration;
using LMS_Data_Access_Layer.Models.Learning_Management_System;
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


            // School Mappings
            CreateMap<School, School_GetDTO>().ReverseMap();
            CreateMap<School_AddDTO, School>().ReverseMap();




            // Academic Year Mappings



            //Semester Mappings


            // Classroom Mappings


            // Grade Mappings


            // Building Mappings

            // Academic Degree Mappings


            // Floor Mappings

            // Section Mappings

            // Subject Mappings


            // Subject Category Mappings



        }
    }
}
