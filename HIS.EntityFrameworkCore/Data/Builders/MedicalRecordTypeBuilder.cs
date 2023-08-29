using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public class MedicalRecordTypeBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicalRecordType>().HasData(
                new MedicalRecordType((int)MedicalRecordTypes.KHAMBENH, MedicalRecordTypes.KHAMBENH.ToString(), "Khám bệnh", (int)MedicalRecordGroupTypes.KHAMBENH, null, 1, false),

                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NGOAITRU__CHUNG, MedicalRecordTypes.DTRI_NGOAITRU__CHUNG.ToString(), "Ngoại trú chung", (int)MedicalRecordGroupTypes.DTRI_NGOAITRU, null, 1, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NGOAITRU__RHM, MedicalRecordTypes.DTRI_NGOAITRU__RHM.ToString(), "Ngoại trú Răng Hàm Mặt", (int)MedicalRecordGroupTypes.DTRI_NGOAITRU, null, 2, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NGOAITRU__TMH, MedicalRecordTypes.DTRI_NGOAITRU__TMH.ToString(), "Ngoại trú Tai Mũi Họng", (int)MedicalRecordGroupTypes.DTRI_NGOAITRU, null, 3, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NGOAITRU__MAT, MedicalRecordTypes.DTRI_NGOAITRU__MAT.ToString(), "Ngoại trú Mắt", (int)MedicalRecordGroupTypes.DTRI_NGOAITRU, null, 4, false),

                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__CHUNG, MedicalRecordTypes.DTRI_NOITRU__CHUNG.ToString(), "Nội trú chung", (int)MedicalRecordGroupTypes.DTRI_NOITRU, null, 1, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__NOIKHOA, MedicalRecordTypes.DTRI_NOITRU__NOIKHOA.ToString(), "Nội trú Nội khoa", (int)MedicalRecordGroupTypes.DTRI_NOITRU, null, 2, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__NHIKHOA, MedicalRecordTypes.DTRI_NOITRU__NHIKHOA.ToString(), "Nội trú Nhi khoa", (int)MedicalRecordGroupTypes.DTRI_NOITRU, null, 3, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__TRUYENNHIEM, MedicalRecordTypes.DTRI_NOITRU__TRUYENNHIEM.ToString(), "Nội trú Truyền nhiễm", (int)MedicalRecordGroupTypes.DTRI_NOITRU, null, 4, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__PHUKHOA, MedicalRecordTypes.DTRI_NOITRU__PHUKHOA.ToString(), "Nội trú Phụ khoa", (int)MedicalRecordGroupTypes.DTRI_NOITRU, null, 5, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__SANKHOA, MedicalRecordTypes.DTRI_NOITRU__SANKHOA.ToString(), "Nội trú Sản khoa", (int)MedicalRecordGroupTypes.DTRI_NOITRU, null, 6, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__SOSINH, MedicalRecordTypes.DTRI_NOITRU__SOSINH.ToString(), "Nội trú Sơ sinh", (int)MedicalRecordGroupTypes.DTRI_NOITRU, null, 7, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__TAMTHAN, MedicalRecordTypes.DTRI_NOITRU__TAMTHAN.ToString(), "Nội trú Tâm thần", (int)MedicalRecordGroupTypes.DTRI_NOITRU, null, 8, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__DALIEU, MedicalRecordTypes.DTRI_NOITRU__DALIEU.ToString(), "Nội trú Da liễu", (int)MedicalRecordGroupTypes.DTRI_NOITRU, null, 9, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__DIEUDUONG_PHCN, MedicalRecordTypes.DTRI_NOITRU__DIEUDUONG_PHCN.ToString(), "Nội trú Điều dưỡng - Phục hồi chức năng", (int)MedicalRecordGroupTypes.DTRI_NOITRU, null, 10, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__HUYETHOC_TRUYENMAU, MedicalRecordTypes.DTRI_NOITRU__HUYETHOC_TRUYENMAU.ToString(), "Nội trú Huyết học - Truyền máu", (int)MedicalRecordGroupTypes.DTRI_NOITRU, null, 11, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__NGOAIKHOA, MedicalRecordTypes.DTRI_NOITRU__NGOAIKHOA.ToString(), "Nội trú Ngoại khoa", (int)MedicalRecordGroupTypes.DTRI_NOITRU, null, 12, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__BONG, MedicalRecordTypes.DTRI_NOITRU__BONG.ToString(), "Nội trú Bỏng", (int)MedicalRecordGroupTypes.DTRI_NOITRU, null, 13, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__UNGBUOU, MedicalRecordTypes.DTRI_NOITRU__UNGBUOU.ToString(), "Nội trú Ung bướu", (int)MedicalRecordGroupTypes.DTRI_NOITRU, null, 14, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__RHM, MedicalRecordTypes.DTRI_NOITRU__RHM.ToString(), "Nội trú Răng Hàm Mặt", (int)MedicalRecordGroupTypes.DTRI_NOITRU, null, 15, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__TMH, MedicalRecordTypes.DTRI_NOITRU__TMH.ToString(), "Nội trú Tai Mũi Họng", (int)MedicalRecordGroupTypes.DTRI_NOITRU, null, 16, false),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__MAT, MedicalRecordTypes.DTRI_NOITRU__MAT.ToString(), "Nội trú Mắt", (int)MedicalRecordGroupTypes.DTRI_NOITRU, null, 17, false)
            );
        }
    }
}
