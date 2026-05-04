using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Business_Layer.DTO.Grade_DTO
{
    public class Grade_Add_DTO
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string Name { get; set; }
        public string? DateFrom { get; set; }
        public string? DateTo { get; set; }
        [ForeignKey("Section")]
        public long SectionID { get; set; }
        public int? SAT { get; set; }
        public int? SUN { get; set; }
        public int? MON { get; set; }
        public int? TUS { get; set; }
        public int? WED { get; set; }
        public int? THRU { get; set; }
        public int? FRI { get; set; }
    }
}
