using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())// using: içerisine yazılan nesneler using bitince bellekten atar. Performans sağlar.
            {
                var addedEntity = context.Entry(entity);// veritabanı ile ilişkilendirdi
                addedEntity.State = EntityState.Added; // ekleme işlemi
                context.SaveChanges(); // değişiklikleri kayıt eder
            }
        }

        public void Delete(Product entity)
        {

            using (NorthwindContext context = new NorthwindContext())// using: içerisine yazılan nesneler using bitince bellekten atar. Performans sağlar.
            {
                var deletedEntity = context.Entry(entity);// veritabanı ile ilişkilendirdi
                deletedEntity.State = EntityState.Deleted; // silme işlemi
                context.SaveChanges(); // değişiklikleri kayıt eder
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter); // tek bir veriyi getirmek için kullanılır.
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList(); // Filtre null ise Veritabanındaki product ı bulup listeye çevirip geri verir. Değilse, filtreli halini getir.
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())// using: içerisine yazılan nesneler using bitince bellekten atar. Performans sağlar.
            {
                var updatedEntity = context.Entry(entity);// veritabanı ile ilişkilendirdi
                updatedEntity.State = EntityState.Modified; // güncelleme işlemi
                context.SaveChanges(); // değişiklikleri kayıt eder
            }
        }
    }
}
