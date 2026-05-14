using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Data_Access_Layer.Models
{
    public class RolePermission : AuditableEntity
    {
        [Key]
        public long ID { get; set; }

        public bool Allow_View { get; set; }

        public bool Allow_Create { get; set; }

        public bool Allow_Edit { get; set; }

        public bool Allow_Delete { get; set; }

        public bool Allow_Print { get; set; }

        public bool Allow_Export { get; set; }

        public string? PermissionCode { get; set; }  // Optional: A code to represent the specific permission, if needed

        [ForeignKey(nameof(Role))]
        public long RoleId { get; set; }

        [ForeignKey(nameof(Page))]
        public long PageId { get; set; }

        public Role Role { get; set; }

        public Page Page { get; set; }
    }
}

