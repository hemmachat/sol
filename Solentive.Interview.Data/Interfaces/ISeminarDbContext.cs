using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Solentive.Interview.Model;

namespace Solentive.Interview.Data.Interfaces
{
    public interface ISeminarDbContext
    {
        DbSet<Level> Levels { get; set; }
        DbSet<Location> Locations { get; set; }
        DbSet<Seminar> Seminars { get; set; }
        DbSet<Track> Tracks { get; set; }
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}