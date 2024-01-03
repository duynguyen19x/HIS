using HIS.EntityFrameworkCore.Entities.Business;

namespace HIS.EntityFrameworkCore.Views
{
    public class ServiceRequestView : ServiceRequest
    {
        public string UserCode { get; set; }
        public string UserName { get; set; }

        public string PatientCode { get; set; }
        public string PatientName { get; set; }

        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }

        public string RoomCode { get; set; }
        public string RoomName { get; set; }

        public string ExecuteRoomCode { get; set; }
        public string ExecuteRoomName { get; set; }

        public string ExecuteUserCode { get; set; }
        public string ExecuteUserName { get; set; }
    }
}
