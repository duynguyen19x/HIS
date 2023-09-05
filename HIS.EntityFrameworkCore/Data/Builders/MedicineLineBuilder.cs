using HIS.EntityFrameworkCore.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public class ItemLineBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemLine>().HasData(
                new ItemLine()
                {
                    Id = new Guid("05A24915-0BED-4F61-B53D-B5E52482E44C"),
                    Code = "1.01",
                    Name = "Uống",
                    SortOrder = 1
                },
                new ItemLine()
                {
                    Id = new Guid("03BD1FDC-D2B8-4969-A029-5022CA68F31E"),
                    Code = "1.02",
                    Name = "Ngậm",
                    SortOrder = 2
                },
                new ItemLine()
                {
                    Id = new Guid("A29889F5-4943-4520-85FA-441C3EA9E979"),
                    Code = "1.03",
                    Name = "Nhai",
                    SortOrder = 3
                },
                new ItemLine()
                {
                    Id = new Guid("A26814E4-DA59-4317-A297-5CA089EF2DAD"),
                    Code = "1.04",
                    Name = "Đặt dưới lưỡi",
                    SortOrder = 4
                },
                new ItemLine()
                {
                    Id = new Guid("5EADA7DB-843C-453B-8A44-3DE2DACAA27B"),
                    Code = "1.05",
                    Name = "Ngậm dưới lưỡi",
                    SortOrder = 5
                },
                new ItemLine()
                {
                    Id = new Guid("6F90ECFE-4EDE-4241-918B-B18245208F56"),
                    Code = "2.01",
                    Name = "Tiêm bặp",
                    SortOrder = 6
                },
                new ItemLine()
                {
                    Id = new Guid("5EF14843-323D-4FE9-A424-46CA3120FCA9"),
                    Code = "2.02",
                    Name = "Tiêm dưới da",
                    SortOrder = 7
                },
                new ItemLine()
                {
                    Id = new Guid("5D6B6689-0DC3-4F11-94EF-02D288CCE18A"),
                    Code = "2.03",
                    Name = "Tiêm trong da",
                    SortOrder = 8
                },
                new ItemLine()
                {
                    Id = new Guid("CAE9F723-E795-48D5-9730-F19EDCEAA5B6"),
                    Code = "2.04",
                    Name = "Tiêm tĩnh mạch",
                    SortOrder = 9
                },
                new ItemLine()
                {
                    Id = new Guid("FEBB52A6-15BC-4E28-BC84-E928B43B126B"),
                    Code = "2.05",
                    Name = "Tiêm truyền tĩnh mạch",
                    SortOrder = 10
                },
                new ItemLine()
                {
                    Id = new Guid("D075055E-4ED2-4D37-82AE-C9C20CB4F08F"),
                    Code = "2.06",
                    Name = "Tiêm vào ổ khớp",
                    SortOrder = 11
                },
                new ItemLine()
                {
                    Id = new Guid("D36D932C-00DB-451D-9A02-A401DBD89408"),
                    Code = "2.07",
                    Name = "Tiêm nội nhãn cầu",
                    SortOrder = 12
                },
                new ItemLine()
                {
                    Id = new Guid("E578F37B-9F1B-4098-8659-AC510CED491A"),
                    Code = "2.08",
                    Name = "Tiêm trong dịch kích của mắt",
                    SortOrder = 13
                },
                new ItemLine()
                {
                    Id = new Guid("C6FFA735-8813-41EA-8984-5700DBEE1EA7"),
                    Code = "2.09",
                    Name = "Tiêm vào các khoang của cơ thế",
                    SortOrder = 14
                },
                new ItemLine()
                {
                    Id = new Guid("2F6E29A1-9A1F-44B0-8F9E-EA1C8716C23B"),
                    Code = "2.10",
                    Name = "Tiêm",
                    SortOrder = 15
                },
                new ItemLine()
                {
                    Id = new Guid("65CA8FD8-FB9B-4DEA-9C0E-C9A3B6B8FBD8"),
                    Code = "2.11",
                    Name = "Tiêm động mạch khối u",
                    SortOrder = 16
                },
                new ItemLine()
                {
                    Id = new Guid("C0097373-F633-4BEE-B670-2D2C35B5D172"),
                    Code = "2.12",
                    Name = "Tiêm vào khoang tự nhiên",
                    SortOrder = 17
                },
                new ItemLine()
                {
                    Id = new Guid("13165217-8025-44E0-A92B-1F8318D56282"),
                    Code = "2.13",
                    Name = "Tiêm vào khối u",
                    SortOrder = 18
                },
                new ItemLine()
                {
                    Id = new Guid("6EDBA7A9-20FE-49C0-9925-BA3B32ED32A0"),
                    Code = "2.14",
                    Name = "Tiêm truyền tĩnh mạch",
                    SortOrder = 19
                },
                new ItemLine()
                {
                    Id = new Guid("41C24FFD-81F8-44F4-92F7-B3E5D418C8C7"),
                    Code = "2.15",
                    Name = "Tiêm truyền",
                    SortOrder = 20
                },
                new ItemLine()
                {
                    Id = new Guid("2BD555B2-74AE-4B3F-9D27-DE30E10BF16F"),
                    Code = "3.01",
                    Name = "Bôi",
                    SortOrder = 21
                },
                new ItemLine()
                {
                    Id = new Guid("75017C25-2AD7-4CCE-B206-38735FD3584D"),
                    Code = "3.02",
                    Name = "Xoa ngoài",
                    SortOrder = 22
                },
                new ItemLine()
                {
                    Id = new Guid("71EDC6F8-3DB6-4375-9005-C5328627FA28"),
                    Code = "3.03",
                    Name = "Dán trên da",
                    SortOrder = 23
                },
                new ItemLine()
                {
                    Id = new Guid("5A807206-9AEF-481D-87B6-88F464E6FD46"),
                    Code = "3.04",
                    Name = "Xịt ngoài da",
                    SortOrder = 24
                },
                new ItemLine()
                {
                    Id = new Guid("60F3158E-73F2-453F-AF90-072B6B25C644"),
                    Code = "3.05",
                    Name = "Dùng ngoài",
                    SortOrder = 1
                },
                new ItemLine()
                {
                    Id = new Guid("CB51640D-BD7E-4CBA-B64D-191D4162EFA4"),
                    Code = "4.01",
                    Name = "Đặt âm đạo",
                    SortOrder = 25
                },
                new ItemLine()
                {
                    Id = new Guid("3DF25942-AFC9-4ED5-88B3-A0FF7B0AD968"),
                    Code = "4.02",
                    Name = "Đặt hậu môn",
                    SortOrder = 26
                },
                new ItemLine()
                {
                    Id = new Guid("49783593-80CA-4A9F-8FF9-5D359307498C"),
                    Code = "4.03",
                    Name = "Thụt hậu môn - trực tràng",
                    SortOrder = 27
                },
                new ItemLine()
                {
                    Id = new Guid("D558492B-6628-40CA-AADF-5DDA7701681A"),
                    Code = "4.04",
                    Name = "Đặt",
                    SortOrder = 28
                },
                new ItemLine()
                {
                    Id = new Guid("7990C54F-DC34-4A62-A8DA-201D22C1069D"),
                    Code = "4.05",
                    Name = "Đặt tử cung",
                    SortOrder = 29
                },
                new ItemLine()
                {
                    Id = new Guid("8F65D7CF-BBD9-44F4-B556-20472AA4A5F0"),
                    Code = "4.06",
                    Name = "Thụt",
                    SortOrder = 30
                },
                new ItemLine()
                {
                    Id = new Guid("229172A9-7464-4216-8B11-4E587E4C280C"),
                    Code = "5.01",
                    Name = "Phun mù",
                    SortOrder = 31
                },
                new ItemLine()
                {
                    Id = new Guid("6CDF2301-9621-4F73-9C62-F48AB80245C8"),
                    Code = "5.02",
                    Name = "Dạng hít",
                    SortOrder = 32
                },
                new ItemLine()
                {
                    Id = new Guid("0DF82239-15DD-41EE-AFC8-67CB51D5F3F6"),
                    Code = "5.03",
                    Name = "Bột hít",
                    SortOrder = 33
                },
                new ItemLine()
                {
                    Id = new Guid("CA37423B-25C7-4A84-A32D-8767BF14352B"),
                    Code = "5.04",
                    Name = "Xịt",
                    SortOrder = 34
                },
                new ItemLine()
                {
                    Id = new Guid("D81EFDE6-F750-4A66-ADF3-A9092BB8EA9B"),
                    Code = "5.05",
                    Name = "Khí dung",
                    SortOrder = 35
                },
                new ItemLine()
                {
                    Id = new Guid("B12F310C-C12A-4F8F-A9BD-DDD38B4EEBCF"),
                    Code = "5.06",
                    Name = "Đường hô hấp",
                    SortOrder = 36
                },
                new ItemLine()
                {
                    Id = new Guid("8D9CD0B1-2407-4CC3-9D94-314602E26508"),
                    Code = "5.07",
                    Name = "Xịt mũi",
                    SortOrder = 37
                },
                new ItemLine()
                {
                    Id = new Guid("0C8BA522-0E4B-40A0-9D93-936F5350853E"),
                    Code = "5.08",
                    Name = "Xịt họng",
                    SortOrder = 38
                },
                new ItemLine()
                {
                    Id = new Guid("7B3A86DC-9B0C-43F8-94A9-E4EEC9916E30"),
                    Code = "5.09",
                    Name = "Thuốc mũi",
                    SortOrder = 39
                },
                new ItemLine()
                {
                    Id = new Guid("1EF26D8F-57D7-423C-A8C6-E3A20A249B37"),
                    Code = "6.01",
                    Name = "Nhỏ mũi",
                    SortOrder = 40
                },
                new ItemLine()
                {
                    Id = new Guid("E485D3CC-5A96-48C9-9ED3-8725BB0136EF"),
                    Code = "6.02",
                    Name = "Nhỏ mắt",
                    SortOrder = 41
                },
                new ItemLine()
                {
                    Id = new Guid("379C8A46-145D-4956-AF5D-2D48D9D55087"),
                    Code = "6.03",
                    Name = "Tra mắt",
                    SortOrder = 42
                },
                new ItemLine()
                {
                    Id = new Guid("7D92B632-0CCF-4BE5-A044-C3EE549FDB9F"),
                    Code = "6.04",
                    Name = "Nhỏ tai",
                    SortOrder = 43
                },
                new ItemLine()
                {
                    Id = new Guid("08F7B3C2-09DA-4B4A-9C98-75C8562807EE"),
                    Code = "6.09",
                    Name = "Dung dịch",
                    SortOrder = 44
                });
        }
    }
}
