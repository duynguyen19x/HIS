using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Icd
{
    public class SIcdDto : EntityDto<Guid?>
    {
        public string Code { get; set; }
        public string MohReportCode { get; set; } // mã báo cáo BYT
        public string Name { get; set; }
        public string NameEnglish { get; set; } // tên tiếng anh
        public string NameCommon { get; set; } // tên thường dùng
        public string ChapterCode { get; set; } // mã chương
        public string ChapterName { get; set; } // tên chương
        public string ChapterNameEnglish { get; set; } // tên chương tiếng anh
        public string MainGroupCode { get; set; } // mã nhóm chính
        public string MainGroupName { get; set; } // tên nhóm chính
        public string MainGroupNameEnglish { get; set; } // tên nhóm chính tiếng anh
        public string SubGroup1Code { get; set; } // mã nhóm phụ 1
        public string SubGroup1Name { get; set; } // tên nhóm phụ 1
        public string SubGroup1NameEnglish { get; set; } // tên nhóm phụ 1 tiếng anh
        public string SubGroup2Code { get; set; } // mã nhóm phụ 2
        public string SubGroup2Name { get; set; } // tên nhóm phụ 2
        public string SubGroup2NameEnglish { get; set; } // tên nhóm phụ 2 tiếng anh
        public string TypeCode { get; set; } // mã loại
        public string TypeName { get; set; } // tên loại
        public string TypeNameEnglish { get; set; } // tên loại tiếng anh

        public string Description { get; set; }
        public bool Inactive { get; set; }
    }
}
