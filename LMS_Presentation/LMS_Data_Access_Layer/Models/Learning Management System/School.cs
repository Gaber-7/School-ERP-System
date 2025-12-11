using LMS_Data_Access_Layer.Models.Administration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Data_Access_Layer.Models.Learning_Management_System
{
    public class School : AuditableEntity
    {
        [Key]
        public long ID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "School cannot be longer than 100 characters.")]
        public string Name { get; set; }
        public string? Address { get; set; }
        public string? ReportHeaderOneEn { get; set; }
        public string? ReportHeaderOneAr { get; set; }
        public string? ReportHeaderTwoEn { get; set; }
        public string? ReportHeaderTwoAr { get; set; }
        public string? ReportImage { get; set; }
        public int? MaximumPeriodCountTimeTable { get; set; }
        public int? MaximumPeriodCountRemedials { get; set; }
        //[ForeignKey("WeekStartDay")]
        //public long? WeekStartDayID { get; set; }
        //public Days? WeekStartDay { get; set; }

        //[ForeignKey("WeekEndDay")]
        //public long? WeekEndDayID { get; set; }
        //public Days? WeekEndDay { get; set; }

        public string? City { get; set; }
        public string? CitySubdivision { get; set; }
        public string? PostalZone { get; set; }
        public string? StreetName { get; set; }
        public string? BuildingNumber { get; set; }
        public string? VatNumber { get; set; }
        public string? CRN { get; set; } //Commercial Registration Number
        public string? ClientID { get; set; }
        public string? SecretNumber1 { get; set; }
        public string? SecretNumber2 { get; set; }

        //public ICollection<Grade>? Grades { get; set; } = new HashSet<Grade>();
        public ICollection<Building>? Buildings { get; set; } = new HashSet<Building>();
        public ICollection<Student>? Students { get; set; } = new HashSet<Student>();
        public ICollection<AcademicYear> AcademicYears { get; set; } = new HashSet<AcademicYear>();
        public ICollection<Section>? Sections { get; set; } = new HashSet<Section>();
   



    }
}
