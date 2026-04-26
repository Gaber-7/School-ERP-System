using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Business_Layer.DTO.Floor_DTO
{
    public class Floor_Get_DTO
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public long BuildingID { get; set; }
        public string BuildingName { get; set; }
        public long FloorMonitorID { get; set; }
        public string FloorMonitorName { get; set; }
        //public long? InsertedByUserId { get; set; }


    }
}
