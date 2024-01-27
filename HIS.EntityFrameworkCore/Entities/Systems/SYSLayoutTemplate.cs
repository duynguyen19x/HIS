using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    public class SYSLayoutTemplate
    {
        public string LayoutTemplateName { get; set; }

        public int RefTypeID { get; set; }

        public string TemplateConfig { get; set; }

        public string Description { get; set; }

        public Guid? UserID { get; set; }

        public bool IsPublic { get; set; }
    }
}