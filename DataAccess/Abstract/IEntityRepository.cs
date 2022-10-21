using Entities.Abstract;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    // generic constraint-- generic kısıt
    // class referans tip
    // where T:ClassiIEntity ile generic constraint yapıldı
    // IEntity demek; hem IEntity olabilir hem de referansı olan classlar olabilir.
    // new() : newlenebilir olmalı şartı eklendi 
    public interface IEntityRepository<T> where T : class, IEntity, new() // Generic kullandıldı. Çünkü Product,Category gibi nesnelerin tiplerini otomatize etmek için kullanırız.
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); // Expression ile istediğimiz gibi filter yapmamıza yarar
        T Get(Expression<Func<T, bool>> filter);  // tek bir data getirmek için kullanılır
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
