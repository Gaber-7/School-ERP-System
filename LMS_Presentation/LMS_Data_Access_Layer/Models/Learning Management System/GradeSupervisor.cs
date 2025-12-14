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
    public class GradeSupervisor : AuditableEntity
    {
        [Key]
        public long ID { get; set; }

        [ForeignKey("Grade")]
        public long GradeID { get; set; }
        public Grade Grade { get; set; }

        [ForeignKey("Employee")]
        public long EmployeeID { get; set; }
        public Employee Employee { get; set; }
    }
}
