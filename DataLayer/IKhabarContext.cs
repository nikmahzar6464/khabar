using Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DataLayer
{
    public interface IKhabarContext
    {
        int SaveChanges();
        EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : class;
        DbSet<Category> Categories { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<News> News { get; set; }
        DbSet<NewsPicture> NewsPicture { get; set; }
        DbSet<Log> Logs { get; set; }


        EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class;

    }
}