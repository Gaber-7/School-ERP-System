using AutoMapper;
using LMS_Business_Layer.DTO.AcademicYearDTO;
using LMS_Business_Layer.DTO.DepartmentDTO;
using LMS_Business_Layer.DTO.School_DTO;
using LMS_Business_Layer.DTO.SectionDTO;
using LMS_Business_Layer.DTO.Semester_DTO;
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
            CreateMap<AcademicYear, AcademicYear_Get_DTO>()
                .ForMember(dest => dest.schoolName,
                           opt => opt.MapFrom(src => src.School.Name));
            // ADD Mapping
            CreateMap<AcademicYear_Add_DTO, AcademicYear>();

            // UPDATE Mapping
            CreateMap<AcademicYear_Get_DTO, AcademicYear>();

            //Semester Mappings
            CreateMap<Semester, Semester_Get_DTO>()
                 .ForMember(dest => dest.AcademicYearName,
                    opt => opt.MapFrom(src => src.AcademicYear.Name));
            CreateMap<Semester_Post_DTO, Semester>();
            // Update Mapping
            CreateMap<SemesterEditDTO, Semester>();

            // Section Mappings
            CreateMap<Section, Section_GetDTO>()
                .ForMember(dest => dest.SchoolName,
                           opt => opt.MapFrom(src => src.school.Name));
            // Add Mapping Section
            CreateMap<Section_AddDTO, Section>();
            // Update Mapping Section
            CreateMap<Section_EditDTO, Section>();


            // Classroom Mappings


            // Grade Mappings


            // Building Mappings

            // Academic Degree Mappings


            // Floor Mappings



            // Subject Mappings


            // Subject Category Mappings



        }
    }
}
