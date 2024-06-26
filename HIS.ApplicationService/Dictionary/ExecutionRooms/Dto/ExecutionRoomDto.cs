﻿using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.ExecutionRoom
{
    public  class ExecutionRoomDto : EntityDto<Guid?>
    {
        public Guid? ServiceId { get; set; }
        public Guid? RoomId { get; set; }

        /// <summary>
        /// Đánh dấu phòng thực hiện chính
        /// </summary>
        public bool IsMain { get; set; }
        public bool IsCheck { get; set; }

        public string RoomCode { get; set; }
        public string RoomName { get; set; }
    }
}
