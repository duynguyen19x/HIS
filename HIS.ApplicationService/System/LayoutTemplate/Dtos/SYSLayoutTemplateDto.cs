using AutoMapper.Configuration.Annotations;
using HIS.Core.Application.Services.Dto;
using HIS.EntityFrameworkCore.Entities.Systems;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.LayoutTemplate.Dtos
{
    public class SYSLayoutTemplateDto : EntityDto<Guid?>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int TemplateType { get; set; }

        //public string TemplateValue { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Chia sẻ mẫu tùy chỉnh của người dùng cho những người dùng khác.
        /// </summary>
        public bool IsPublic { get; set; }

        /// <summary>
        /// Mẫu tùy chỉnh của người dùng.
        /// </summary>
        public Guid? UserId { get; set; }

        public IList<SYSLayoutTemplateValueColumnDto> TemplateValueColumn {  get; set; }
    }
}
