using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.PatientRecords;
using HIS.Dtos.Dictionaries.ReceptionTypes;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.Receptions
{
    /// <summary>
    /// Dữ liệu cho chức năng tiếp đón
    /// </summary>
    public class ReceptionDto : EntityDto<Guid>
    {
        public Guid UserID { get; set; }
        public Guid DepartmentID { get; set; }
        public Guid RoomID { get; set; }
        public DateTime ReceptionDate { get; set; }
        public int ReceptionType { get; set; }
        public Guid ServiceID { get; set; }
        public Guid ExecuteDepartmentID { get; set; }
        public Guid ExecuteRoomID { get; set; }

        public PatientRecordDto PatientRecord { get; set; }

    }
}
