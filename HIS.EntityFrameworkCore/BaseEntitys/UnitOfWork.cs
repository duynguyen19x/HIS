using HIS.EntityFrameworkCore.DbContexts;

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
        private readonly MedicalSolutionsDbContext _dbContext;

        public UnitOfWork(MedicalSolutionsDbContext dbContext)
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
