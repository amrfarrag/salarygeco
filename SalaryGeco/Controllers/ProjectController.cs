using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SalaryGeco.Models;
using System.Threading.Tasks;
using System.Threading;
using System.Data.Entity;

namespace SalaryGeco.Controllers
{
    public class ProjectController : ApiController
    {
        SalaryContext ctx = new SalaryContext();
        [ResponseType(typeof(List<Project>))]
        [HttpGet]
        public async Task<IHttpActionResult> GetAllProjects()
        {
            return Ok(await ctx.Projects.ToListAsync());
        }
        [ResponseType(typeof(Project))]
        [HttpGet]
        
        public async Task<IHttpActionResult> GetProject(int id)
        {
            return Ok(await ctx.Projects.FindAsync(id));
        }
        public bool PostProject()
        {

        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing) ctx.Dispose();
            base.Dispose(disposing);
        }

    }
}
