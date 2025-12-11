using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Data_Access_Layer.Models.Learning_Management_System
{
    public class Semester : AuditableEntity
    {
        [Key]
        public long ID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string Name { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public bool? IsCurrent { get; set; }
        public bool? IsActive { get; set; }

        [ForeignKey("AcademicYear")]
        public long? AcademicYearID { get; set; }
        public AcademicYear? AcademicYear { get; set; }
    }
}
