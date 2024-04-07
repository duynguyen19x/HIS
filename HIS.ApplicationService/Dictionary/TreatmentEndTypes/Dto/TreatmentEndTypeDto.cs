using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.TreatmentEndTypes.Dto
{
    public class TreatmentEndTypeDto : EntityDto<int>
    {
        public virtual string Code { get; set; }

        public virtual string Name { get; set; }

        /// <summary>
        /// Dùng cho bệnh nhân khám bệnh và điều trị ngoại trú
        /// </summary>
        public virtual bool IsForOutPatient { get; set; }

        /// <summary>
        /// Dùng cho bệnh nhân điều trị nội trú
        /// </summary>
        public virtual bool IsForInPatient { get; set; }

        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }

        public virtual bool Inactive { get; set; }
    }
}
