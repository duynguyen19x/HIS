using HIS.ApplicationService.Base;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Department;
using HIS.Dtos.Dictionaries.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Room
{
    public interface ISRoomService : IBaseDictionaryService<SRoomDto, GetAllSRoomInput>
    {
        Task<ApiResultList<SRoomDto>> GetByStocks();
    }
}
