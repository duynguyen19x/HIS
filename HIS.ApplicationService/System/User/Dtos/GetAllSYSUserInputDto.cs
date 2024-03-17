using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.User.Dtos
{
    public class GetAllSYSUserInputDto : PagedAndSortedResultRequestDto
    {
        public string FullNameFilter { get; set; }
        public string FirstNameFilter { get; set; }
        public string LastNameFilter { get; set; }
        public string UsernameFilter { get; set; }
        public string PasswordFilter { get; set; }
        public string EmailFilter { get; set; }
        public string TelFilter { get; set; }
        public string MobileFilter { get; set; }
        public string DescriptionFilter { get; set; }
        public Guid? EmployeeFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
