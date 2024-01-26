using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.RoomType
{
    public class GetAllRoomTypeInput : PagedResultRequestDto
    {
        public string RoomTypeCodeFilter { get; set; }
        public string RoomTypeNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
