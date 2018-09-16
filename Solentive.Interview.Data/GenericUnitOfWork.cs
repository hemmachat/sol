using Solentive.Interview.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solentive.Interview.Data
{
    public class GenericUnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public GenericUnitOfWork(DbContext context)
        {
            _context = context;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
