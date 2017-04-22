using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DataModel
{
    public class SalaryContext : DbContext
    {
        public SalaryContext() : base("salarydb")
        {

        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employer> Employers { get; set; }

        public DbSet<ProjectEmployer> ProjectsEmployers { get; set; }

    }
}