using SibersTest.Data.EF;
using SibersTest.Data.Interfaces;
using SibersTest.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SibersTest.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationContext _context;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            People = new PersonRepository(_context);
            Projects = new ProjectRepository(_context);
        }
        public IPersonRepository People { get; private set; }

        public IProjectRepository Projects { get; private set; }

        public int Complete() => _context.SaveChanges();

        public void Dispose() => _context.Dispose();
    }
}
