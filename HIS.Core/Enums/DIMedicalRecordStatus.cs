using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Enums
{
    public enum DIMedicalRecordStatus
    {
        OPEN = 0, // Đang khám và điều trị
        CLOSE = 1, // Đã kết thúc khám và điều trị
        STORE = 2 // Đã lưu trữ hồ sơ bệnh án
    }
}
