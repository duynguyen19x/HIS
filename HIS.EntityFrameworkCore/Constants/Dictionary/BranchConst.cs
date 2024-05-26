using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Constants
{
    public class BranchConst
    {
        public const int MaxBranchCodeLength = 50;
        public const int MinBranchCodeLength = 0;

        public const int MaxBranchNameLength = 255;
        public const int MinBranchNameLength = 0;

        public const int MaxMediOrgCodeLength = 255;
        public const int MinMediOrgCodeLength = 0;

        public const int MaxMediOrgAcceptCodeLength = 4000;
        public const int MinMediOrgAcceptCodeLength = 0;

        public const int MaxParentOrganizationNameLength = 255;
        public const int MinParentOrganizationNameLength = 0;

        public const int MaxPhoneNumberLength = 50;
        public const int MinPhoneNumberLength = 0;

        public const int MaxEmailLength = 50;
        public const int MinEmailLength = 0;

        public const int MaxAddressLength = 255;
        public const int MinAddressLength = 0;

        public const int MaxDescriptionLength = 255;
        public const int MinDescriptionLength = 0;
    }
}
