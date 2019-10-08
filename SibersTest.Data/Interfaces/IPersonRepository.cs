using SibersTest.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SibersTest.Data.Interfaces
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person GetPersonWithProjects(int id);
    }
}
