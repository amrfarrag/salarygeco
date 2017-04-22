using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataModel
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public virtual ICollection<ProjectEmployer> ProjectsEmployers { get; set; }
    }
}