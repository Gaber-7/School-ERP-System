using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Business_Layer.DTO.Semester_DTO
{
    public class Semester_Get_DTO
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public long? AcademicYearID { get; set; }
        public string AcademicYearName { get; set; }
        public bool? IsCurrent { get; set; }
        public bool? IsActive { get; set; }
        public long? InsertedByUserId { get; set; }
    }
}
