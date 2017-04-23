using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public interface IRepositry<TEntity> : IDisposable
    {
        IQueryable<TEntity> GetAll();
        TEntity Read(int id );
        void Delete(TEntity entity);
        void Update(TEntity entity);
        void Create(TEntity entity);
        void Save();

    }
}
