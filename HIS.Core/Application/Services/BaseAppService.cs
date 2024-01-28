using HIS.Core.Domain.Uow;
using HIS.Core.Runtime.Session;
using IObjectMapper = HIS.Core.ObjectMapping.IObjectMapper;

namespace HIS.Core.Application.Services
{
    public abstract class BaseAppService : IAppService
    {
        /// <summary>
        /// Reference to <see cref="IUnitOfWorkManager"/>.
        /// </summary>
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

        /// <summary>
        /// Gets current unit of work.
        /// </summary>
        protected IActiveUnitOfWork CurrentUnitOfWork { get { return UnitOfWorkManager.Current; } }

        public IAppSession AppSession { get; set; }

        /// <summary>
        /// Reference to the object to object mapper.
        /// </summary>
        public IObjectMapper ObjectMapper { get; set; }

        protected BaseAppService()
        {
            AppSession = NullAppSession.Instance;
        }
    }
}
