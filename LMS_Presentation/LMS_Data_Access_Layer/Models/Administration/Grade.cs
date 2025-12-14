using LMS_Data_Access_Layer.Models.Learning_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace LMS_Data_Access_Layer.Models.Administration
{
    public class Grade : AuditableEntity
    {
        [Key]
        public long ID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string Name { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }

        public ICollection<Classroom> Classrooms { get; set; } = new HashSet<Classroom>();
        public ICollection<Subject> Subjects { get; set; } = new HashSet<Subject>();
        public ICollection<GradeSupervisor> GradeSupervisors { get; set; } = new HashSet<GradeSupervisor>();

        [ForeignKey("Section")]
        public long SectionID { get; set; }
        public Section Section { get; set; }

        //[ForeignKey("UpgradeTo")]
        //public long? UpgradeToID { get; set; }
        //public Grade? UpgradeTo { get; set; }

        public int? SAT { get; set; }
        public int? SUN { get; set; }
        public int? MON { get; set; }
        public int? TUS { get; set; }
        public int? WED { get; set; }
        public int? THRU { get; set; }
        public int? FRI { get; set; }
    }
}
