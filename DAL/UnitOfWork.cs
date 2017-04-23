using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DAL
{
   public class UnitOfWork :IDisposable
    {
        private SalaryContext context;
        private GeneralRepositry<Employer> _employerrepositry;
        private GeneralRepositry<Project> _projectrepositry;
        private GeneralRepositry<ProjectEmployer> _projectemployerrepositry;
        public UnitOfWork()
        {
            context = new SalaryContext();
        }
        public GeneralRepositry<Employer> EmployerRepositry
        {
            get
            {
                if (_employerrepositry == null) _employerrepositry = new GeneralRepositry<Employer>(context);
                return _employerrepositry;
            }
        }
        public GeneralRepositry<Project> ProjectRepositry
        {
            get
            {
                if (_projectrepositry == null) _projectrepositry = new GeneralRepositry<Project>(context);
                return _projectrepositry;
            }
        }
        public GeneralRepositry<ProjectEmployer> ProjectEmployerRepositry
        {
            get
            {
                if (_projectemployerrepositry == null) _projectemployerrepositry = new GeneralRepositry<ProjectEmployer>(context);
                return _projectemployerrepositry;
            }
        }

        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(this);

        }
    }
}
