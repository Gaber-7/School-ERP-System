using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Business_Layer.DTO.BuildingDTO
{
    public class Building_Get_DTO
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public long SchoolID { get; set; }
        public string SchoolName { get; set; }
        public long? InsertedByUserId { get; set; }

    }
}
