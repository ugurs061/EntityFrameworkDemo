using Core.DataAccess;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.DataAccsess.EntityFramework
{
    // bir tane entity ve context tipi ister
    public class EfEntityRepositoryBase<TEntity, TContext>:IEntityRepository<TEntity>// hangi tabloyu verirsem(TEntity) onun EntityRepositorysi çalışsın
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())// using: içerisine yazılan nesneler using bitince bellekten atar. Performans sağlar.
            {
                var addedEntity = context.Entry(entity);// veritabanı ile ilişkilendirdi
                addedEntity.State = EntityState.Added; // ekleme işlemi
                context.SaveChanges(); // değişiklikleri kayıt eder
            }
        }

        public void Delete(TEntity entity)
        {

            using (TContext context = new TContext())// using: içerisine yazılan nesneler using bitince bellekten atar. Performans sağlar.
            {
                var deletedEntity = context.Entry(entity);// veritabanı ile ilişkilendirdi
                deletedEntity.State = EntityState.Deleted; // silme işlemi
                context.SaveChanges(); // değişiklikleri kayıt eder
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter); // tek bir veriyi getirmek için kullanılır. 2 tane veri dönerse hata verir.
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList(); // Filtre null ise Veritabanındaki product ı bulup listeye çevirip geri verir. Değilse, filtreli halini getir.
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())// using: içerisine yazılan nesneler using bitince bellekten atar. Performans sağlar.
            {
                var updatedEntity = context.Entry(entity);// veritabanı ile ilişkilendirdi
                updatedEntity.State = EntityState.Modified; // güncelleme işlemi
                context.SaveChanges(); // değişiklikleri kayıt eder
            }
        }
    }
}
