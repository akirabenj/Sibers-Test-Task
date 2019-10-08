using System;
using System.Collections.Generic;

namespace SibersTest.Data.Entities
{
    public class Project : BaseEntity
    {
        public string CustomerCompany { get; set; }
        public string ExecutorCompany { get; set; }
        public int SupervisorId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Priority { get; set; }

        public virtual ICollection<Person> PeopleOnProject { get; set; }
    }
}
