using CleanArcheticture.Domain.Entites;
using CleanArcheticture.Domain.Interfaces;
using CleanArcheticture.Infrastructure.Data;
using CleanArcheticture.Infrastructure.Repository;
using CleanArcheticture.Infrastructure.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcheticture.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private IRepository<Movie> _Movie;
        private IRepository<MovieTypes> _MovieTypes;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IRepository<Movie> Movies => _Movie ??= new Repository<Movie>(_context);

        public IRepository<MovieTypes> MovieTypes => _MovieTypes ??= new Repository<MovieTypes>(_context);

        public int Commit() =>  _context.SaveChanges();

        public void Dispose() => _context.Dispose();
    }
}
