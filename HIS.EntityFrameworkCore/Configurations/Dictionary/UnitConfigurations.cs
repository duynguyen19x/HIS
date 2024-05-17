using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class UnitConfigurations : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.ToTable("DIC_Unit");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);

            builder.HasData(
               new Unit()
               {
                   Id = new Guid("C587599C-A6A6-454F-8E30-2A92DAC6F588"),
                   Code = "VIEN",
                   Name = "Viên",
                   SortOrder = 1
               },
               new Unit()
               {
                   Id = new Guid("6CC9258A-5F48-4C22-8CD6-61C0795F5405"),
                   Code = "LAN",
                   Name = "Lần",
                   SortOrder = 2
               },
               new Unit()
               {
                   Id = new Guid("AE0ECE26-BB4C-4B23-95CB-1A5D66114634"),
                   Code = "LO",
                   Name = "Lọ",
                   SortOrder = 3
               },
               new Unit()
               {
                   Id = new Guid("DA514A31-4DFC-4445-99BD-4AE29359AD48"),
                   Code = "TUYT",
                   Name = "Tuýt",
                   SortOrder = 4
               },
               new Unit()
               {
                   Id = new Guid("44AB6FFC-F1A9-47D0-90AB-9F09D767C286"),
                   Code = "ONG",
                   Name = "Ống",
                   SortOrder = 5
               },
               new Unit()
               {
                   Id = new Guid("0762AEBF-CBB8-4102-B923-A30DF490F75D"),
                   Code = "6",
                   Name = "Hộp",
                   SortOrder = 6
               },
               new Unit()
               {
                   Id = new Guid("7A0FED4A-E62A-4E9F-8E92-7332127CA248"),
                   Code = "TUB",
                   Name = "Tub",
                   SortOrder = 7
               },
               new Unit()
               {
                   Id = new Guid("9FF4F404-68BD-4780-99BC-1033227CBE3D"),
                   Code = "GOI",
                   Name = "Gói",
                   SortOrder = 8
               },
               new Unit()
               {
                   Id = new Guid("2198D1C0-57FA-453F-B605-9CEF55929067"),
                   Code = "CUON",
                   Name = "Cuộn",
                   SortOrder = 9
               },
               new Unit()
               {
                   Id = new Guid("BF42CBF7-B5AC-4503-B73D-D91F4051FA8F"),
                   Code = "ML",
                   Name = "ml",
                   SortOrder = 10
               },
               new Unit()
               {
                   Id = new Guid("9E12370E-B3CE-4862-8E7D-83D8F7EC56D1"),
                   Code = "LIT",
                   Name = "Lít",
                   SortOrder = 11
               },
               new Unit()
               {
                   Id = new Guid("3BE8BC27-3940-451C-87F5-C062DF716872"),
                   Code = "GAM",
                   Name = "Gam",
                   SortOrder = 12
               },
               new Unit()
               {
                   Id = new Guid("CC8713C1-536A-4835-BD7E-187603566F95"),
                   Code = "KG",
                   Name = "Kg",
                   SortOrder = 13
               },
               new Unit()
               {
                   Id = new Guid("49793DB4-C0CE-43C1-B439-EACD554FA06E"),
                   Code = "MET",
                   Name = "Met",
                   SortOrder = 14
               },
               new Unit()
               {
                   Id = new Guid("A7E37E54-47B8-4716-B493-B657D4981E35"),
                   Code = "MINI",
                   Name = "Minimet",
                   SortOrder = 15
               },
               new Unit()
               {
                   Id = new Guid("FD96BAD9-B254-4B37-8EB9-ADA68FE7DADA"),
                   Code = "CHAI",
                   Name = "Chai",
                   SortOrder = 16
               },
               new Unit()
               {
                   Id = new Guid("8D7A7B33-F2ED-4B4B-A869-3AD32FD9D192"),
                   Code = "TUI",
                   Name = "Túi",
                   SortOrder = 17
               },
               new Unit()
               {
                   Id = new Guid("E04B1F07-6F05-403E-AC09-B999CAC0DF3E"),
                   Code = "CAI",
                   Name = "Cái",
                   SortOrder = 18
               },
               new Unit()
               {
                   Id = new Guid("E46826B4-76F9-4B32-84B3-B9730E732839"),
                   Code = "CHIEC",
                   Name = "Chiếc",
                   SortOrder = 19
               },
               new Unit()
               {
                   Id = new Guid("46EA45FF-BA5E-4F6F-BBC6-EBE65446EFE8"),
                   Code = "GAM",
                   Name = "Gam",
                   SortOrder = 20
               },
               new Unit()
               {
                   Id = new Guid("FC7ACF3A-2C10-4200-9448-C3180C0A4400"),
                   Code = "MIENG",
                   Name = "Miếng",
                   SortOrder = 21
               });
        }
    }
}
