using CleanArcheticture.Domain.Interfaces;
using CleanArcheticture.Infrastructure;

namespace CleanArchitecture.Infrastructure
    {
    public class UnitOfWork : IUnitOfWork
        {
        private readonly AppDbContext _context;

        // Keep created repositories in a cache (dictionary)
        private readonly Dictionary<Type, object> _repositories = new();

        public UnitOfWork(AppDbContext context)
            {
            _context = context;
            }
        public IRepository<TEntity> Repository<TEntity>() where TEntity : class
            {
            // if we already created it once, reuse it
            if (_repositories.ContainsKey(typeof(TEntity)))
                return (IRepository<TEntity>)_repositories[typeof(TEntity)];

            // else, create a new Repository<TEntity>, add to cache, return it
            var repository = new Repository<TEntity>(_context);
            _repositories.Add(typeof(TEntity), repository);
            return repository;
            }

        public int Commit() => _context.SaveChanges();
        public void Dispose() => _context.Dispose();
        }
    }
