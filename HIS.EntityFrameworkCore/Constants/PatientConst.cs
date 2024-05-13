using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Constants
{
    public class PatientConst
    {
        public const int MaxPatientCodeLength = 50;
        public const int MinPatientCodeLength = 0;

        public const int MaxPatientNameLength = 255;
        public const int MinPatientNameLength = 0;

        public const int MaxBirthPlaceLength = 255;
        public const int MinBirthPlaceLength = 0;

        public const int MaxWorkPlaceLength = 255;
        public const int MinWorkPlaceLength = 0;

        public const int MaxAddressLength = 400;
        public const int MinAddressLength = 0;

        public const int MaxPhoneNumberLength = 50;
        public const int MinPhoneNumberLength = 0;

        public const int MaxEmailLength = 50;
        public const int MinEmailLength = 0;

        public const int MaxIdentificationNumberLength = 50;
        public const int MinIdentificationNumberLength = 0;

        public const int MaxIssueByLength = 120;
        public const int MinIssueByLength = 0;

        public const int MaxDescriptionLength = 120;
        public const int MinDescriptionLength = 0;

    }
}
