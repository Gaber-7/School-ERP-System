using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Business_Layer.DTO.School_DTO
{
    public class School_AddDTO
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "School cannot be longer than 100 characters.")]
        public string Name { get; set; }
        public string? Address { get; set; }
        public int? MaximumPeriodCountTimeTable { get; set; }
        public int? MaximumPeriodCountRemedials { get; set; }
        public string? ReportHeaderOneEn { get; set; }
        public string? ReportHeaderOneAr { get; set; }
        public string? StreetName { get; set; }
        public string? BuildingNumber { get; set; }
        public string? City { get; set; }

    }
}
