using HIS.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Authorization
{
    [Serializable]
    public class UserIdentifier : IUserIdentifier
    {
        public Guid? BranchId { get; protected set; }

        public Guid UserId { get; protected set; }

        protected UserIdentifier()
        {

        }

        public UserIdentifier(Guid? branchId, Guid userId)
        {
            BranchId = branchId;
            UserId = userId;
        }

        public static UserIdentifier Parse(string userIdentifierString)
        {
            if (Check.IsNullOrDefault(userIdentifierString))
            {
                throw new ArgumentNullException(nameof(userIdentifierString), "user at branch can not be null or empty!");
            }

            var splitted = userIdentifierString.Split('@');
            if (splitted.Length == 1)
            {
                return new UserIdentifier(null, splitted[0].To<Guid>());

            }

            if (splitted.Length == 2)
            {
                return new UserIdentifier(splitted[1].To<Guid>(), splitted[0].To<Guid>());
            }

            throw new ArgumentException("user at branch is not properly formatted", nameof(userIdentifierString));
        }

        public string ToUserIdentifierString()
        {
            if (BranchId == null)
            {
                return UserId.ToString();
            }

            return UserId + "@" + BranchId;
        }
    }
}
