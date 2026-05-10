using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Business_Layer.DTO.Page_DTO
{
    public class Page_Get_DTO
    {
        public long ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string En_name { get; set; }

        [Required(ErrorMessage = "الاسم مطلوب")]
        [StringLength(100, ErrorMessage = "لا يمكن أن يكون الاسم أطول من 100 حرف")]
        public string Ar_name { get; set; }

        public string? Icon { get; set; }

        public string? Route { get; set; }

        public long Order { get; set; }
        public long? Page_ID { get; set; }

        public List<Page_Get_DTO> Children { get; set; } = new List<Page_Get_DTO>();
    }
}
