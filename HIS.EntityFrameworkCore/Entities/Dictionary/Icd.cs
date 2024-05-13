using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Mã bệnh
    /// </summary>
    [Table("DIIcd10")]
    public class Icd : AuditedEntity<Guid>
    {
        public Guid? ChapterIcdId { get; set; }

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

        public ChapterIcd ChapterIcd { get; set; }
    }
}
