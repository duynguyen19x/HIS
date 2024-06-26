﻿using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Receptions.Dto
{
    public class ReceptionServiceDto : EntityDto<Guid>
    {
        public Guid ServiceId { get; set; } // dịch vụ
        public Guid ExecuteRoomId { get; set; } // phòng thực hiện
        public int SortOrder { get; set; } // thứ tự hiển thị
    }
}
