using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Data.Entity;

namespace DAL
{
    public class GeneralRepositry<TEntity> : IRepositry<TEntity> 
        where TEntity :class
    {
        internal SalaryContext context;
        internal DbSet<TEntity> table;
        public GeneralRepositry(SalaryContext ctx)
        {
            this.context = ctx;
            this.table = this.context.Set<TEntity>();
        }
        public void Create(TEntity entity)
        {
            table.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            table.Remove(entity);
        }

        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(this);
        }

        public TEntity Get(int id)
        {
            return table.Find(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return table;
        }

        public void Save()
        {
            context.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {

            table.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
