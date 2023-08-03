using HIS.EntityFrameworkCore.EntityFrameworkCore;

namespace MedicalSolutions.EntityFrameworkCore.SeedWork
{
    public interface IUnitOfWork
    {
        public void Commit();
        public void Dispose();
        public UnitOfWork Begin();
    }

    public class UnitOfWork : Disposable, IUnitOfWork, IDisposable
    {
        private readonly HISDbContext _dbContext;

        public UnitOfWork(HISDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public UnitOfWork Begin()
        {
            return new UnitOfWork(_dbContext);
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
