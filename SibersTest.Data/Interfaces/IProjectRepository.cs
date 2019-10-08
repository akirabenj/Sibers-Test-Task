using SibersTest.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SibersTest.Data.Interfaces
{
    public interface IProjectRepository : IRepository<Project>
    {
        Project GetProjectWithPeople(int id);
        //Person GetSupervisor(int supervisorId);
    }
}
