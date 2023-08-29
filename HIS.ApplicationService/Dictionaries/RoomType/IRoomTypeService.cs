using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.DepartmentType;
using HIS.Dtos.Dictionaries.RoomType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.RoomType
{
    public interface IRoomTypeService : IBaseDictionaryService<RoomTypeDto, GetAllRoomTypeInput, int>
    {
    }
}
