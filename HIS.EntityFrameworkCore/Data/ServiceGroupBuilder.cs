using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.Utilities.Enums;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data
{
    public static class ServiceGroupBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SServiceGroup>().HasData(
                new SServiceGroup()
                {
                    Id = new Guid("A080ECAA-6CD6-459D-A450-D89351E0904D"),
                    Code = ((int)ServiceGroupTypes.BloodTest).ToString(),
                    Name = "Xét nghiệm huyết học",
                    SortOrder = (int)ServiceGroupTypes.BloodTest
                },
                new SServiceGroup()
                {
                    Id = new Guid("33DD59D7-AB44-47FE-8B21-8500BF6E6CEE"),
                    Code = ((int)ServiceGroupTypes.BiochemicalTest).ToString(),
                    Name = "Xét nghiệm sinh hóa",
                    SortOrder = (int)ServiceGroupTypes.BiochemicalTest
                },
                new SServiceGroup()
                {
                    Id = new Guid("A13FA2CD-851C-4E89-A8CA-BDACEE567757"),
                    Code = ((int)ServiceGroupTypes.MicrobiologicalTest).ToString(),
                    Name = "Xét nghiệm vi sinh",
                    SortOrder = 3
                },
                new SServiceGroup()
                {
                    Id = new Guid("8878FB20-578E-46A6-8F61-62789C234BDE"),
                    Code = ((int)ServiceGroupTypes.UrineTest).ToString(),
                    Name = "Xét nghiệm nước tiểu",
                    SortOrder = (int)ServiceGroupTypes.UrineTest
                },
                new SServiceGroup()
                {
                    Id = new Guid("9414782A-9194-4801-91A0-253963A605EB"),
                    Code = ((int)ServiceGroupTypes.DiagnosticPuncture).ToString(),
                    Name = "Dịch chọc dò",
                    SortOrder = (int)ServiceGroupTypes.DiagnosticPuncture
                },
                new SServiceGroup()
                {
                    Id = new Guid("D4837941-9CC1-4F53-84F7-3E99EDC8F508"),
                    Code = ((int)ServiceGroupTypes.PathologicalAnatomy).ToString(),
                    Name = "Giải phẫu bệnh lý",
                    SortOrder = 6
                },
                new SServiceGroup()
                {
                    Id = new Guid("E70F016C-39E7-4DED-AA20-9BFFD9FADD59"),
                    Code = ((int)ServiceGroupTypes.Surgery).ToString(),
                    Name = "Phẫu thuật",
                    SortOrder = (int)ServiceGroupTypes.Surgery
                },
                new SServiceGroup()
                {
                    Id = new Guid("401DBB33-3EB1-44AE-8B3F-51E25996C311"),
                    Code = ((int)ServiceGroupTypes.MedicalExamination).ToString(),
                    Name = "Khám",
                    SortOrder = (int)ServiceGroupTypes.MedicalExamination
                },
                new SServiceGroup()
                {
                    Id = new Guid("1219FE7A-CECB-4A94-8FDC-2F6D0F48FBC9"),
                    Code = ((int)ServiceGroupTypes.EEG).ToString(),
                    Name = "Điện não đồ",
                    SortOrder = 9
                },
                new SServiceGroup()
                {
                    Id = new Guid("906307B7-F7E2-457A-A3D1-62A10BA9DAA3"),
                    Code = ((int)ServiceGroupTypes.ECG).ToString(),
                    Name = "Điện tâm đồ",
                    SortOrder = (int)ServiceGroupTypes.ECG
                },
                new SServiceGroup()
                {
                    Id = new Guid("3B3DED9E-71AB-4D31-868C-A704D0604509"),
                    Code = ((int)ServiceGroupTypes.FunctionalRecovery).ToString(),
                    Name = "Phục hồi chức năng",
                    SortOrder = (int)ServiceGroupTypes.FunctionalRecovery
                },
                new SServiceGroup()
                {
                    Id = new Guid("0DDD75BE-A32C-47F2-B5F1-5138B5997791"),
                    Code = ((int)ServiceGroupTypes.SurgicalIntervention).ToString(),
                    Name = "Thủ thuật",
                    SortOrder = 12
                },
                new SServiceGroup()
                {
                    Id = new Guid("9F474388-E722-4AD2-B194-8A7D8DEF97FD"),
                    Code = ((int)ServiceGroupTypes.Endoscopy).ToString(),
                    Name = "Nội soi",
                    SortOrder = (int)ServiceGroupTypes.Endoscopy
                },
                new SServiceGroup()
                {
                    Id = new Guid("17819944-BC22-47C5-AFC3-108881FD5714"),
                    Code = ((int)ServiceGroupTypes.Xray).ToString(),
                    Name = "XQuang thường",
                    SortOrder = (int)ServiceGroupTypes.Xray
                },
                new SServiceGroup()
                {
                    Id = new Guid("FF0073EF-BE7C-46E1-ADC3-99E58871F5C6"),
                    Code = ((int)ServiceGroupTypes.XrayDigital).ToString(),
                    Name = "XQuang kỹ thuật số",
                    SortOrder = (int)ServiceGroupTypes.XrayDigital
                },
                new SServiceGroup()
                {
                    Id = new Guid("0711132B-D3A9-46D1-9EE1-74154FACEF37"),
                    Code = ((int)ServiceGroupTypes.MRI).ToString(),
                    Name = "Cộng hưởng từ",
                    SortOrder = 16
                },
                new SServiceGroup()
                {
                    Id = new Guid("4BE0AD49-AC80-4A2B-9A92-03B3FFD4F3B6"),
                    Code = ((int)ServiceGroupTypes.CTScan).ToString(),
                    Name = "Cắt lớp vi tính",
                    SortOrder = (int)ServiceGroupTypes.CTScan
                },
                new SServiceGroup()
                {
                    Id = new Guid("914B8E89-4C56-4998-9707-DEF10FD23FBB"),
                    Code = ((int)ServiceGroupTypes.Ultrasound).ToString(),
                    Name = "Siêu âm thường",
                    SortOrder = (int)ServiceGroupTypes.Ultrasound
                },
                new SServiceGroup()
                {
                    Id = new Guid("E43040FC-0E85-436C-8537-5C18E29F61DA"),
                    Code = ((int)ServiceGroupTypes.Doppler).ToString(),
                    Name = "Siêu âm màu",
                    SortOrder = 19
                },
                new SServiceGroup()
                {
                    Id = new Guid("12105142-6179-41C2-A56C-5364A2B852F5"),
                    Code = ((int)ServiceGroupTypes.MealPortion).ToString(),
                    Name = "Suất ăn",
                    SortOrder = 20
                },
                new SServiceGroup()
                {
                    Id = new Guid("1FD09E01-450A-43CE-8BF4-C32AEE87753D"),
                    Code = ((int)ServiceGroupTypes.Blood).ToString(),
                    Name = "Máu",
                    SortOrder = (int)ServiceGroupTypes.Blood
                },
                new SServiceGroup()
                {
                    Id = new Guid("DA2F4B6D-FD50-4CAB-BEBD-319458064222"),
                    Code = ((int)ServiceGroupTypes.BloodProduct).ToString(),
                    Name = "Chế phẩm máu",
                    SortOrder = (int)ServiceGroupTypes.BloodProduct
                },
                new SServiceGroup()
                {
                    Id = new Guid("964200B8-4AE6-434D-A461-909391444B40"),
                    Code = ((int)ServiceGroupTypes.Material).ToString(),
                    Name = "Vật tư",
                    SortOrder = (int)ServiceGroupTypes.Material
                },
                new SServiceGroup()
                {
                    Id = new Guid("B4573FB1-32A6-45E3-9782-07066D090A5C"),
                    Code = ((int)ServiceGroupTypes.Medicine).ToString(),
                    Name = "Thuốc",
                    SortOrder = (int)ServiceGroupTypes.Medicine
                },
                new SServiceGroup()
                {
                    Id = new Guid("998836B2-3B5B-4C1C-9B4B-7F6CC1E52B74"),
                    Code = ((int)ServiceGroupTypes.Bed).ToString(),
                    Name = "Giường",
                    SortOrder = (int)ServiceGroupTypes.Bed
                },
                new SServiceGroup()
                {
                    Id = new Guid("3B082A29-237D-4926-8209-F2876D292189"),
                    Code = ((int)ServiceGroupTypes.Transportation).ToString(),
                    Name = "Vận chuyển",
                    SortOrder = (int)ServiceGroupTypes.Transportation
                },
                new SServiceGroup()
                {
                    Id = new Guid("0A5A8DC0-67A7-41E9-8FB3-1F5E6F8D874D"),
                    Code = ((int)ServiceGroupTypes.Other).ToString(),
                    Name = "Khác",
                    SortOrder = (int)ServiceGroupTypes.Other
                });
        }
    }
}
