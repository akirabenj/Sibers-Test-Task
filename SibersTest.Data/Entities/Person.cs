using System;
using System.Collections.Generic;

namespace SibersTest.Data.Entities
{
    public class Person : BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
        //public virtual ICollection<ProjectsPeople> ProjectsPeople { get; set; }
    }
}
