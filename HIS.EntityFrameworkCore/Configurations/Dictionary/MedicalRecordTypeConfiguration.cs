﻿using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class MedicalRecordTypeConfiguration : IEntityTypeConfiguration<MedicalRecordType>
    {
        public void Configure(EntityTypeBuilder<MedicalRecordType> builder)
        {
            builder.ToTable("SMedicalRecordTypes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.MedicalRecordTypeCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.MedicalRecordTypeName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.MedicalRecordTypeGroupId).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasOne(t => t.MedicalRecordTypeGroup).WithMany().HasForeignKey(p => p.MedicalRecordTypeGroupId);

            builder.HasData(
                new MedicalRecordType((int)MedicalRecordTypes.KHAMBENH, "Khám Bệnh", (int)MedicalRecordTypeGroups.KHAMBENH, 1, new DateTime(2024, 1, 1)),

                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NGOAITRU, "Bệnh Án Ngoại Trú (Chung)", (int)MedicalRecordTypeGroups.DTRI_NGOAITRU, 1, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NGOAITRU__RHM, "Bệnh Án Ngoại Trú (Răng - Hàm - Mặt)", (int)MedicalRecordTypeGroups.DTRI_NGOAITRU, 2, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NGOAITRU__TMH, "Bệnh Án Ngoại Trú (Tai - Mũi - Họng)", (int)MedicalRecordTypeGroups.DTRI_NGOAITRU, 3, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NGOAITRU__YHCT, "Bệnh Án Ngoại Trú (Y Học Cổ Truyền)", (int)MedicalRecordTypeGroups.DTRI_NGOAITRU, 4, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NGOAITRU__MAT, "Bệnh Án Ngoại Trú (Mắt)", (int)MedicalRecordTypeGroups.DTRI_NGOAITRU, 5, new DateTime(2024, 1, 1)),

                //new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU, "Nội trú chung", (int)MedicalRecordTypeGroups.DTRI_NOITRU, 1),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__NOIKHOA, "Bệnh Án Nội Khoa", (int)MedicalRecordTypeGroups.DTRI_NOITRU, 2, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__NHIKHOA, "Bệnh Án Nhi Khoa", (int)MedicalRecordTypeGroups.DTRI_NOITRU, 3, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__TRUYENNHIEM, "Bệnh Án Truyền Nhiễm", (int)MedicalRecordTypeGroups.DTRI_NOITRU, 4, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__PHUKHOA, "Bệnh Án Phụ Khoa", (int)MedicalRecordTypeGroups.DTRI_NOITRU, 5, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__SANKHOA, "Bệnh Án Sản Khoa", (int)MedicalRecordTypeGroups.DTRI_NOITRU, 6, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__SOSINH, "Bệnh Án Sơ Sinh", (int)MedicalRecordTypeGroups.DTRI_NOITRU, 7, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__TAMTHAN, "Bệnh Án Tâm Thần", (int)MedicalRecordTypeGroups.DTRI_NOITRU, 8, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__DALIEU, "Bệnh Án Da Liễu", (int)MedicalRecordTypeGroups.DTRI_NOITRU, 9, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__DIEUDUONG_PHCN, "Bệnh Án Điều Dưỡng - Phục Hồi Chức Năng", (int)MedicalRecordTypeGroups.DTRI_NOITRU, 10, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__HUYETHOC_TRUYENMAU, "Bệnh Án Huyết Học - Truyền Máu", (int)MedicalRecordTypeGroups.DTRI_NOITRU, 11, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__NGOAIKHOA, "Bệnh Án Ngoại Khoa", (int)MedicalRecordTypeGroups.DTRI_NOITRU, 12, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__BONG, "Bệnh Án Bỏng", (int)MedicalRecordTypeGroups.DTRI_NOITRU, 13, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__UNGBUOU, "Bệnh Án Ung Bướu", (int)MedicalRecordTypeGroups.DTRI_NOITRU, 14, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__RHM, "Bệnh Án Răng-Hàm-Mặt", (int)MedicalRecordTypeGroups.DTRI_NOITRU, 15, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__TMH, "Bệnh Án Tai-Mũi-Họng", (int)MedicalRecordTypeGroups.DTRI_NOITRU, 16, new DateTime(2024, 1, 1)),
                new MedicalRecordType((int)MedicalRecordTypes.DTRI_NOITRU__MAT, "Bệnh Án Mắt", (int)MedicalRecordTypeGroups.DTRI_NOITRU, 17, new DateTime(2024, 1, 1))


            );
        }
    }
}
