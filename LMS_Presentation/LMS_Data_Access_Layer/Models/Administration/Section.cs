using LMS_Data_Access_Layer.Models.Learning_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
namespace LMS_Data_Access_Layer.Models.Administration
{
    public class Section : AuditableEntity
    {
        [Key]
        public long ID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string Name { get; set; }

        [ForeignKey("school")]
        public long SchoolID { get; set; }
        public School school { get; set; }
        public ICollection<Grade> Grades { get; set; } = new HashSet<Grade>();
    }
}
