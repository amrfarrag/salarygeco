﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataModel
{
    public enum State
    {
        Active,Passive
    }
    public class ProjectEmployer
    {
        public int ProjectEmployerID { get; set; }
        public int ProjectID { get; set; }
        public int EmployerID { get; set; }
        public virtual Project project { get; set; }
        public virtual Employer employer { get; set; }
        public State state { get; set; }
    }
}