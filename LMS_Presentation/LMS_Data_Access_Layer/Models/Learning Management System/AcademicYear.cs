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
    public class AcademicYear : AuditableEntity
    {
        [Key]
        public long ID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string Name { get; set; }
        public DateOnly DateFrom { get; set; }
        public DateOnly DateTo { get; set; }
        public bool IsActive { get; set; }
        public DateOnly? SummerCourseDateFrom { get; set; }
        public DateOnly? SummerCourseDateTo { get; set; }

        [ForeignKey("School")]
        public long schoolId { get; set; }
        public School School { get; set; }


       public ICollection<Semester> Semesters { get; set; }
       public ICollection<Classroom> Classrooms { get; set; }

      

    }
}
