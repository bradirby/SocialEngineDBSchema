using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco;

namespace SocialEngine.DataAccess.Interfaces
{
    public interface IBaseRepository<T>
    {
        void Insert(T entity);
        void Delete(T entity);
        void Delete(object primaryKey);
        void Update(T entity);
        void Update(T entity, Snapshot<T> snapshot);
        Snapshot<T> GetSnapshot(T entity);
        T GetById(int id);
    }
}
