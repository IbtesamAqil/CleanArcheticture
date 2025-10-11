using CleanArcheticture.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcheticture.Domain.Interfaces
    {
    public interface IUnitOfWork : IDisposable
        {
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;
        int Commit();
        }
    }
