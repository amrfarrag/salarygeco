using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DAL
{
   public class UnitOfWork
    {

        private GeneralRepositry<Employer> _employer;
        private GeneralRepositry<Project> _project;
        private GeneralRepositry<ProjectEmployer> _projectemployer;
    }
}
