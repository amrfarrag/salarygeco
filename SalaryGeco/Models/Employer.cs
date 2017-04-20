using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalaryGeco.Models
{
    public class Employer
    {
        public int EmployerID { get; set; }
        public string EmployerName { get; set; }
        public string EmployerCode { get; set; }
        public virtual ICollection<ProjectEmployer> ProjectsEmployers { get; set; }
    }
}