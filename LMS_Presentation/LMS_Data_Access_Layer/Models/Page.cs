using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Data_Access_Layer.Models
{
    public class Page
    {
        [Key]
        public long ID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string En_name { get; set; }

        [Required(ErrorMessage = "الاسم مطلوب")]
        [StringLength(100, ErrorMessage = "لا يمكن أن يكون الاسم أطول من 100 حرف")]
        public string Ar_name { get; set; }
        public string? arDisplayName_name { get; set; }
        public string? enDisplayName_name { get; set; }
        public long Order { get; set; }
        public string? Icon { get; set; }
        public string? Route { get; set; }
        public bool IsDisplay { get; set; } = true;
        public bool IsActive { get; set; } = true;
        public string? PermissionKey { get; set; }
        [ForeignKey("Parent")]
        public long? Page_ID { get; set; }
        public Page Parent { get; set; }
        public ICollection<Page> ChildPages { get; set; } = new List<Page>();
    }
}
