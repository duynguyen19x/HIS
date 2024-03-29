﻿using HIS.Core.Services.Dto;

namespace HIS.Dtos.Dictionaries.RoomType
{
    public class RoomTypeDto : EntityDto<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}
