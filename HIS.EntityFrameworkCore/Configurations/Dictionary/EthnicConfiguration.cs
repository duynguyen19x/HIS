﻿using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class EthnicConfiguration : IEntityTypeConfiguration<Ethnicity>
    {
        public void Configure(EntityTypeBuilder<Ethnicity> builder)
        {
            builder.HasData(
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170901"), "01", "13", "Ba na", 1, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170902"), "02", "49", "Bố y", 2, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170903"), "03", "52", "Brâu", 3, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170904"), "04", "17", "Chăm", 4, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170905"), "05", "32", "Chơ ro", 5, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170906"), "06", "36", "Chu ru", 6, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170907"), "07", "44", "Chứt", 7, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170908"), "08", "30", "Co", 8, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170909"), "09", "48", "Cống", 9, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170910"), "10", "16", "Cơ ho", 10, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170911"), "11", "47", "Cờ lao", 11, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170912"), "12", "9", "Dao", 12, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170913"), "13", "12", "Ê đê", 13, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170914"), "14", "10", "Gia rai", 14, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170915"), "15", "25", "Giấy", 15, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170916"), "16", "27", "Gié triêng", 16, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170917"), "17", "8", "H mông", 17, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170918"), "18", "19", "H rê", 18, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170919"), "19", "35", "Hà nhì", 19, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170920"), "20", "4", "Hoa", 20, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170921"), "21", "26", "K tu", 21, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170922"), "22", "33", "Kháng", 22, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170923"), "23", "5", "Khơ me", 23, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170924"), "24", "29", "Khơ mú", 24, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170925"), "25", "1", "Kinh", 25, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170926"), "26", "38", "La chí", 26, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170927"), "27", "39", "La ha", 27, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170928"), "28", "41", "La hù", 28, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170929"), "29", "37", "Lào", 29, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170930"), "30", "43", "Lô lô", 30, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170931"), "31", "42", "Lự", 31, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170932"), "32", "20", "M nông", 32, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170933"), "33", "28", "Mạ", 33, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170934"), "34", "45", "Mảng", 34, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170935"), "35", "6", "Mường", 35, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170936"), "36", "11", "Ngái", 36, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170937"), "37", "7", "Nùng", 37, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170938"), "38", "53", "Ơ đu", 38, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170939"), "39", "46", "Pà thén", 39, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170940"), "40", "40", "Phù lá", 40, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170941"), "41", "51", "Pu péo", 41, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170942"), "42", "21", "Rag lai", 42, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170943"), "43", "54", "Rơ man", 43, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170944"), "44", "15", "Sán chay", 44, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170945"), "45", "18", "Sán dìu", 45, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170946"), "46", "50", "Si la", 46, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170947"), "47", "31", "Tà ôi", 47, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170948"), "48", "2", "Tày", 48, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170949"), "49", "3", "Thái", 49, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170950"), "50", "24", "Thố", 50, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170951"), "51", "23", "Vân kiều", 51, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170952"), "52", "22", "X tiêng", 52, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170953"), "53", "34", "Xinh mun", 53, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170954"), "54", "14", "Xơ đăng", 54, new DateTime(2024, 1, 1)),
                new Ethnicity(new Guid("9C01CA1A-FB5B-4620-A217-0046C3170999"), "99", "55", "Nước ngoài", 99, new DateTime(2024, 1, 1))
                );
        }
    }
}
