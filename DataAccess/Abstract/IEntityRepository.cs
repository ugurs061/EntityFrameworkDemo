using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>// Generic kullandıldı. Çünkü Product,Category gibi nesnelerin tiplerini otomatize etmek için kullanırız.
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // Expression ile istediğimiz gibi filter yapmamıza yarar
        T Get(Expression<Func<T, bool>> filter);  // tek bir data getirmek için kullanılır
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
