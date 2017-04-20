using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SalaryGeco.Models
{
    public class SalaryDBInit : CreateDatabaseIfNotExists<SalaryContext>
    {
        protected override void Seed(SalaryContext context)
        {
            var project1 = new Project() { ProjectName = "cargel" };
            var employer1 = new Employer() { EmployerName = "amr", EmployerCode = "4510" };
            var employerproject1 = new ProjectEmployer()
            {
                project = project1,
                employer = employer1,
                state = State.Active
            };
            context.ProjectsEmployers.Add(employerproject1);

            base.Seed(context);
        }
    }
}