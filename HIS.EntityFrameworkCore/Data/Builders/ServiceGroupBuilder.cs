using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public static class ServiceGroupBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceGroup>().HasData(
                new ServiceGroup()
                {
                    Id = new Guid("A080ECAA-6CD6-459D-A450-D89351E0904D"),
                    Code = "XN-HH",
                    Name = "Xét nghiệm huyết học",
                    SortOrder = (int)ServiceGroupTypes.BloodTest
                },
                new ServiceGroup()
                {
                    Id = new Guid("33DD59D7-AB44-47FE-8B21-8500BF6E6CEE"),
                    Code = "XN-HS",
                    Name = "Xét nghiệm hóa sinh",
                    SortOrder = (int)ServiceGroupTypes.BiochemicalTest
                },
                new ServiceGroup()
                {
                    Id = new Guid("A13FA2CD-851C-4E89-A8CA-BDACEE567757"),
                    Code = "XN-VS",
                    Name = "Xét nghiệm vi sinh",
                    SortOrder = (int)ServiceGroupTypes.MicrobiologicalTest
                },
                new ServiceGroup()
                {
                    Id = new Guid("8878FB20-578E-46A6-8F61-62789C234BDE"),
                    Code = "XN-NT",
                    Name = "Xét nghiệm nước tiểu",
                    SortOrder = (int)ServiceGroupTypes.UrineTest
                },
                new ServiceGroup()
                {
                    Id = new Guid("9414782A-9194-4801-91A0-253963A605EB"),
                    Code = "XN-DCD",
                    Name = "Dịch chọc dò",
                    SortOrder = (int)ServiceGroupTypes.DiagnosticPuncture
                },
                new ServiceGroup()
                {
                    Id = new Guid("D4837941-9CC1-4F53-84F7-3E99EDC8F508"),
                    Code = "XN-GPB",
                    Name = "Giải phẫu bệnh lý",
                    SortOrder = (int)ServiceGroupTypes.PathologicalAnatomy
                },
                new ServiceGroup()
                {
                    Id = new Guid("9B9DFABB-ABF9-4FEA-B17A-6B5F2C3C01B1"),
                    Code = "XN-KHAC",
                    Name = "Xét nghiệm khác",
                    SortOrder = (int)ServiceGroupTypes.TestOther
                },
                new ServiceGroup()
                {
                    Id = new Guid("E70F016C-39E7-4DED-AA20-9BFFD9FADD59"),
                    Code = "PT",
                    Name = "Phẫu thuật",
                    SortOrder = (int)ServiceGroupTypes.Surgery
                },
                new ServiceGroup()
                {
                    Id = new Guid("401DBB33-3EB1-44AE-8B3F-51E25996C311"),
                    Code = "KH",
                    Name = "Khám",
                    SortOrder = (int)ServiceGroupTypes.MedicalExamination
                },
                new ServiceGroup()
                {
                    Id = new Guid("1219FE7A-CECB-4A94-8FDC-2F6D0F48FBC9"),
                    Code = "TDCN-DND",
                    Name = "Điện não đồ",
                    SortOrder = (int)ServiceGroupTypes.EEG
                },
                new ServiceGroup()
                {
                    Id = new Guid("906307B7-F7E2-457A-A3D1-62A10BA9DAA3"),
                    Code = "TDCN-DTD",
                    Name = "Điện tâm đồ",
                    SortOrder = (int)ServiceGroupTypes.ECG
                },
                new ServiceGroup()
                {
                    Id = new Guid("3B3DED9E-71AB-4D31-868C-A704D0604509"),
                    Code = "TDCN",
                    Name = "Phục hồi chức năng",
                    SortOrder = (int)ServiceGroupTypes.FunctionalRecovery
                },
                new ServiceGroup()
                {
                    Id = new Guid("0DDD75BE-A32C-47F2-B5F1-5138B5997791"),
                    Code = "TT",
                    Name = "Thủ thuật",
                    SortOrder = (int)ServiceGroupTypes.SurgicalIntervention
                },
                new ServiceGroup()
                {
                    Id = new Guid("9F474388-E722-4AD2-B194-8A7D8DEF97FD"),
                    Code = "CDHA-NS",
                    Name = "Nội soi",
                    SortOrder = (int)ServiceGroupTypes.Endoscopy
                },
                new ServiceGroup()
                {
                    Id = new Guid("17819944-BC22-47C5-AFC3-108881FD5714"),
                    Code = "CDHA-XQ",
                    Name = "XQuang thường",
                    SortOrder = (int)ServiceGroupTypes.Xray
                },
                new ServiceGroup()
                {
                    Id = new Guid("FF0073EF-BE7C-46E1-ADC3-99E58871F5C6"),
                    Code = "CDHA-KTS",
                    Name = "XQuang kỹ thuật số",
                    SortOrder = (int)ServiceGroupTypes.XrayDigital
                },
                new ServiceGroup()
                {
                    Id = new Guid("0711132B-D3A9-46D1-9EE1-74154FACEF37"),
                    Code = "CDHA-MRI",
                    Name = "Cộng hưởng từ",
                    SortOrder = (int)ServiceGroupTypes.MRI
                },
                new ServiceGroup()
                {
                    Id = new Guid("4BE0AD49-AC80-4A2B-9A92-03B3FFD4F3B6"),
                    Code = "CDHA-CT",
                    Name = "Cắt lớp vi tính",
                    SortOrder = (int)ServiceGroupTypes.CTScan
                },
                new ServiceGroup()
                {
                    Id = new Guid("914B8E89-4C56-4998-9707-DEF10FD23FBB"),
                    Code = "CDHA-SA",
                    Name = "Siêu âm thường",
                    SortOrder = (int)ServiceGroupTypes.Ultrasound
                },
                new ServiceGroup()
                {
                    Id = new Guid("E43040FC-0E85-436C-8537-5C18E29F61DA"),
                    Code = "CDHA-Doppler",
                    Name = "Siêu âm màu",
                    SortOrder = (int)ServiceGroupTypes.Doppler
                },
                new ServiceGroup()
                {
                    Id = new Guid("12105142-6179-41C2-A56C-5364A2B852F5"),
                    Code = "SA",
                    Name = "Suất ăn",
                    SortOrder = (int)ServiceGroupTypes.MealPortion
                },
                new ServiceGroup()
                {
                    Id = new Guid("1FD09E01-450A-43CE-8BF4-C32AEE87753D"),
                    Code = "MAU",
                    Name = "Máu",
                    SortOrder = (int)ServiceGroupTypes.Blood
                },
                new ServiceGroup()
                {
                    Id = new Guid("DA2F4B6D-FD50-4CAB-BEBD-319458064222"),
                    Code = "CPM",
                    Name = "Chế phẩm máu",
                    SortOrder = (int)ServiceGroupTypes.BloodProduct
                },
                new ServiceGroup()
                {
                    Id = new Guid("964200B8-4AE6-434D-A461-909391444B40"),
                    Code = "VTYT",
                    Name = "Vật tư",
                    SortOrder = (int)ServiceGroupTypes.Material
                },
                new ServiceGroup()
                {
                    Id = new Guid("B4573FB1-32A6-45E3-9782-07066D090A5C"),
                    Code = "THUOC",
                    Name = "Thuốc",
                    SortOrder = (int)ServiceGroupTypes.Medicine
                },
                new ServiceGroup()
                {
                    Id = new Guid("998836B2-3B5B-4C1C-9B4B-7F6CC1E52B74"),
                    Code = "GI",
                    Name = "Giường",
                    SortOrder = (int)ServiceGroupTypes.Bed
                },
                new ServiceGroup()
                {
                    Id = new Guid("3B082A29-237D-4926-8209-F2876D292189"),
                    Code = "VC",
                    Name = "Vận chuyển",
                    SortOrder = (int)ServiceGroupTypes.Transportation
                },
                new ServiceGroup()
                {
                    Id = new Guid("0A5A8DC0-67A7-41E9-8FB3-1F5E6F8D874D"),
                    Code = "KHAC",
                    Name = "Khác",
                    SortOrder = (int)ServiceGroupTypes.Other
                });
        }
    }
}
