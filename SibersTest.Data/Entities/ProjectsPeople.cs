using System;

namespace SibersTest.Data.Entities
{
    public class ProjectsPeople : BaseEntity
    {
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }

        public Person Person { get; set; }
        public Project Project { get; set; }
    }
}
