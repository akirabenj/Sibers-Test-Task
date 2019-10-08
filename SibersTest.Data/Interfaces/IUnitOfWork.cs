using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SibersTest.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository People { get; }
        IProjectRepository Projects { get; }
        Task Complete();
    }
}
