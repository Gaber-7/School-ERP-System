using LMS_Data_Access_Layer.Models.Administration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Data_Access_Layer.Models.Learning_Management_System
{
    public class Classroom : AuditableEntity
    {
        [Key]
        public long ID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string Name { get; set; }
        public int Number { get; set; }

        [ForeignKey("AcademicYear")]
        public long AcademicYearID { get; set; }
        public AcademicYear AcademicYear { get; set; }

        [ForeignKey("Floor")]
        public long FloorID { get; set; }
        public Floor Floor { get; set; }

        [ForeignKey("Grade")]
        public long GradeID { get; set; }
        public Grade Grade { get; set; }


    }
}
