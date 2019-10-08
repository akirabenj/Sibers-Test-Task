using Microsoft.EntityFrameworkCore;
using SibersTest.Data.EF;
using SibersTest.Data.Entities;
using SibersTest.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibersTest.Data.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(ApplicationContext context) : base(context)
        {

        }

        public ApplicationContext Context
        {
            get => Context as ApplicationContext;
        }
        public Person GetPersonWithProjects(int id)
        {
             return Context.People.Include(a => a.Projects).SingleOrDefault(a => a.Id == id);
        }
    }
}
