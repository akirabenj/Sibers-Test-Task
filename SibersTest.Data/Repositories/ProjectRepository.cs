using Microsoft.EntityFrameworkCore;
using SibersTest.Data.EF;
using SibersTest.Data.Entities;
using SibersTest.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SibersTest.Data.Repositories
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationContext context) : base (context)
        { }
        
        public ApplicationContext Context
        {
            get => Context as ApplicationContext; 
        }

        public Project GetProjectWithPeople(int id)
        {
            return Context.Projects.Include(a => a.PeopleOnProject).SingleOrDefault(a => a.Id == id);
        }
    }
}
