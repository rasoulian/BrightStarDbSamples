using BrightstarDB.EntityFramework;

namespace BrightStarDb_App1
{
    public interface IUnitOfWork
    {
        IEntitySet<TEntity> Set<TEntity>() where TEntity : class;
        void DeleteObject(object obj);
        void SaveChanges();
    }

    public partial class DbContext : IUnitOfWork
    {
        public IEntitySet<TEntity> Set<TEntity>() where TEntity : class
        {
            return EntitySet<TEntity>();
        }
    }
}