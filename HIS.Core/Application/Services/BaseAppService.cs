using HIS.Core.Authorization;
using HIS.Core.Domain.Uow;
using HIS.Core.ObjectMapping;
using HIS.Core.Runtime.Session;

namespace HIS.Core.Application.Services
{
    public abstract class BaseAppService : IAppService
    {
        public IUnitOfWorkManager UnitOfWorkManager
        {
            get
            {
                if (_unitOfWorkManager == null)
                {
                    throw new Exception("Must set UnitOfWorkManager before use it.");
                }

                return _unitOfWorkManager;
            }
            set { _unitOfWorkManager = value; }
        }
        private IUnitOfWorkManager _unitOfWorkManager;

        protected IActiveUnitOfWork CurrentUnitOfWork { get { return UnitOfWorkManager.Current; } }

        public IAppSession AppSession { get; set; }

        public IObjectMapper ObjectMapper { get; set; }

        public IPermissionChecker PermissionChecker { get; set; }

        protected BaseAppService()
        {
            AppSession = NullAppSession.Instance;
            PermissionChecker = NullPermissionChecker.Instance;
        }

        protected virtual void CheckPermission(bool requireAll, params string[] permissionNames)
        {
            var userIndentifier = new UserIdentifier(AppSession.BranchId, AppSession.UserId.GetValueOrDefault());
            var isGranted = PermissionChecker.IsGranted(userIndentifier, requireAll, permissionNames);
            if (!isGranted)
            {
                throw new Exception("Người dùng không được cấp quyền!");
            }
        }
    }
}
