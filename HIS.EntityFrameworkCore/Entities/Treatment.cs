﻿using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    public class Treatment : AuditedEntity<Guid>
    {
        public string TreatmentCode { get; set; }
        public DateTime TreatmentDate { get; set; }
        public int TreatmentTypeID { get; set; }
        public int TreatmentStatusID { get; set; }
        public int MedicalRecordTypeID { get; set; }
        public Guid PatientID { get; set; }
        public Guid MedicalRecordID { get; set; }
        public Guid BranchID { get; set; }
        public Guid DepartmentID { get; set; }
        public Guid RoomID { get; set; }
        public Guid UserID { get; set; }
    }
}
