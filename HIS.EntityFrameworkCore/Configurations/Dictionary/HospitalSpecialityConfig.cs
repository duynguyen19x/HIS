using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionary
{
    internal class HospitalSpecialityConfig : IEntityTypeConfiguration<HospitalSpeciality>
    {
        public void Configure(EntityTypeBuilder<HospitalSpeciality> builder)
        {
            builder.HasData(
                new HospitalSpeciality() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("E54079CF-8C27-4869-8509-EE2FA37DD612"), HospitalSpecialityCode = "NOI_KHOA", HospitalSpecialityName = "Chuyên khoa nội", SortOrder = 1 },
                new HospitalSpeciality() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("D7311F7A-6DA4-471B-BD65-7734B246B49B"), HospitalSpecialityCode = "NGOAI_KHOA", HospitalSpecialityName = "Chuyên khoa ngoai", SortOrder = 2 },
                new HospitalSpeciality() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("8BA05025-994D-4B5E-8715-964B1F3A13A5"), HospitalSpecialityCode = "SAN", HospitalSpecialityName = "Chuyên khoa sản - phụ khoa", SortOrder = 3 },
                new HospitalSpeciality() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("FE219F91-5704-49E5-BFC7-F01E26F842BB"), HospitalSpecialityCode = "MAT", HospitalSpecialityName = "Chuyên khoa mắt", SortOrder = 4 },
                new HospitalSpeciality() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("681EAA40-0FB5-41A2-B846-6F48A6954AB2"), HospitalSpecialityCode = "NHI", HospitalSpecialityName = "Chuyên khoa nhi", SortOrder = 5 },
                new HospitalSpeciality() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("B9D76B56-0EB7-4109-BBC4-C939F82229C7"), HospitalSpecialityCode = "RANG", HospitalSpecialityName = "Chuyên khoa răng-hàm-mặt", SortOrder = 6 },
                new HospitalSpeciality() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("5460ECF9-2C35-496B-81CC-5F6E633027BE"), HospitalSpecialityCode = "TMH", HospitalSpecialityName = "Chuyên khoa tai-mũi-họng", SortOrder = 7 },
                new HospitalSpeciality() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("2A5CB6D0-17EE-48B4-8875-3EA49C6F576D"), HospitalSpecialityCode = "UNG_BUOU", HospitalSpecialityName = "Chuyên khoa ung bướu", SortOrder = 8 },
                new HospitalSpeciality() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("F46AB449-8CBC-4C26-A4E8-E342DF9B8B8F"), HospitalSpecialityCode = "DONGY", HospitalSpecialityName = "Chuyên khoa đông y", SortOrder = 9 },
                new HospitalSpeciality() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("283089D3-57B6-40D6-9F86-E9221827850C"), HospitalSpecialityCode = "DA_LIEU", HospitalSpecialityName = "Chuyên khoa da liễu", SortOrder = 10 },
                new HospitalSpeciality() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("3CE1C62F-07EF-4818-B9C4-6E31F3D2141F"), HospitalSpecialityCode = "BENHAN_BAN_CHAN", HospitalSpecialityName = "Chuyên khoa đái tháo đường", SortOrder = 11 },
                new HospitalSpeciality() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("84ED0B08-FEA7-4CD2-B4FC-D7E9C4079AB1"), HospitalSpecialityCode = "PK_NHO", HospitalSpecialityName = "Phòng khám nhỏ", SortOrder = 12 },
                new HospitalSpeciality() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("C3125B12-98D4-4E29-A3C5-35BE114C726A"), HospitalSpecialityCode = "LAM_DICH_VU", HospitalSpecialityName = "Làm dịch vụ", SortOrder = 13 },
                new HospitalSpeciality() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("566BCB28-6B75-4B90-B411-6F8EF2929329"), HospitalSpecialityCode = "TIEM_CHUNG", HospitalSpecialityName = "Tiêm chủng", SortOrder = 14 },
                new HospitalSpeciality() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("ABFF0BDC-8BD4-4AA3-A391-C145CD042408"), HospitalSpecialityCode = "YHCT", HospitalSpecialityName = "Y học cổ truyền", SortOrder = 15 }
                );
        }
    }
}
