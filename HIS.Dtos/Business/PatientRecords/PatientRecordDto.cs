using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.PatientRecords
{
    public class PatientRecordDto : EntityDto<Guid>
    {
        public virtual string Code { get; set; }

        public virtual Guid PatientId { get; set; }
        public virtual string PatientName { get; set; }
        public virtual string IdentificationNumber { get; set; }
        public virtual DateTime? IssueDate { get; set; }
        public virtual string IssueBy { get; set; }

        public virtual DateTime? BirthDate { get; set; }
        public virtual int BirthYear { get; set; }
        public virtual string BirthPlace { get; set; }
        public virtual Guid GenderId { get; set; }
        public virtual Guid CareerId { get; set; }
        public virtual Guid EthnicityId { get; set; }
        public virtual Guid CountryId { get; set; }
        public virtual Guid? ProvinceOrCityId { get; set; }
        public virtual Guid? DistrictId { get; set; }
        public virtual Guid? WardId { get; set; }
        public virtual string Address { get; set; }
        public virtual string Workplace { get; set; }


        public virtual Guid ReceptionUserId { get; set; }
        public virtual Guid ReceptionDepartmentId { get; set; }
        public virtual Guid ReceptionRoomId { get; set; }
        public virtual DateTime ReceptionDate { get; set; }
        public virtual int ReceptionTypeId { get; set; }

    }
}
