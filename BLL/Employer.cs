using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Employer
    {
        public int EmployerID { get; set; }
        public string EmployerCode { get; set; }
        public string EmployerName { get; set; }
        public IEnumerable<Project> Projects { get; set; }
    }
}
