using LMS_Data_Access_Layer.Models.Administration;
using LMS_Data_Access_Layer.Models.HR;
using LMS_Data_Access_Layer.Models.Learning_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Data_Access_Layer.Models
{
    public class Employee  : AuditableEntity
    {
        [Key]
        public long ID { get; set; }
        [Required(ErrorMessage = "User_Name is required")]
        [StringLength(100, ErrorMessage = "Username cannot be longer than 100 characters.")]
        public string User_Name { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string en_name { get; set; }

        [StringLength(100, ErrorMessage = "لا يمكن أن يكون الاسم أطول من 100 حرف")]
        public string? ar_name { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 100 characters.")]
        public string Password { get; set; }
        public string? Mobile { get; set; }
        public string? Phone { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? LicenseNumber { get; set; }   // Driving License Number 
        public string? ExpireDate { get; set; }    // Driving License Expire Date
        public string? Address { get; set; }
        public string? NationalID { get; set; }
        public string? PassportNumber { get; set; }
        public string? ResidenceNumber { get; set; }
        public string? BirthdayDate { get; set; }
        public long? Nationality { get; set; }
        public DateOnly? HireDate { get; set; }
        public string? DateOfLeavingWork { get; set; }
        public decimal? MonthSalary { get; set; }
        public bool? HasAttendance { get; set; }    // هل للموظف حضور وانصراف
        public string? AttendanceTime { get; set; }  // وقت الحضور
        public string? DepartureTime { get; set; }   // وقت الانصراف
        public float? DelayAllowance { get; set; }   // نسبة السماح بالتأخير
        public decimal? AnnualLeaveBalance { get; set; }  // رصيد الإجازة السنوية
        public decimal? CasualLeavesBalance { get; set; }  // رصيد الإجازات العارضة
        public decimal? MonthlyLeaveRequestBalance { get; set; }  // رصيد طلبات الإجازة الشهرية
        public int? GraduationYear { get; set; }  // سنة التخرج
        public string? Note { get; set; }
        public string? SerialNumber { get; set; }   // جهاز الحضور والانصراف
        public bool? CanReceiveRequest { get; set; }   // هل يمكنه استلام الطلبات
        public bool? CanReceiveRequestFromParent { get; set; }   // هل يمكنه استلام الطلبات من المدير المباشر
        public bool? CanReceiveMessageFromParent { get; set; }  // هل يمكنه استلام الرسائل من المدير المباشر
        public bool IsSuspended { get; set; }  // هل الموظف موقوف
        public bool IsRestrictedForLoctaion { get; set; }       // هل الموظف مقيد بموقع جغرافي

        [ForeignKey("ReasonForLeavingWork")]
        public long? ReasonOfLeavingID { get; set; }
        public ReasonForLeavingWork ReasonForLeavingWork { get; set; }

        [ForeignKey("AcademicDegree")]
        public long? AcademicDegreeID { get; set; }
        public AcademicDegree AcademicDegree { get; set; }

        [ForeignKey("Department")]
        public long? DepartmentID { get; set; }
        public Department Department { get; set; }

        [ForeignKey("Role")]
        [Required]
        public long Role_ID { get; set; }
        public Role Role { get; set; }


        [ForeignKey("Job")]
        public long? JobID { get; set; }
        public Job Job { get; set; }

        [ForeignKey("EmployeeType")]
        public long EmployeeTypeID { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public ICollection<Floor> Floors { get; set; } = new HashSet<Floor>();
        public ICollection<SubjectSupervisor> SubjectSupervisors { get; set; } = new HashSet<SubjectSupervisor>();
        public ICollection<GradeSupervisor> GradeSupervisors { get; set; } = new HashSet<GradeSupervisor>();
        public ICollection<LeaveRequest> LeaveRequests { get; set; } = new HashSet<LeaveRequest>();

    }
}
