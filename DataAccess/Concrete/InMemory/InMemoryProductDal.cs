using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; // global değişken isimleri alt çizgi ile başlar. referans oluştu. Veri tabınıymış gibi simüle et
        public InMemoryProductDal() // ctor
        {
           // veritabanlarından gelecek bilgiler
            _products= new List<Product>
            {
                new Product{ ProductId=1, CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15 },
                new Product{ ProductId=2, CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3 },
                new Product{ ProductId=3, CategoryId=2,ProductName="Telefone",UnitPrice=1500,UnitsInStock=2 },
                new Product{ ProductId=4, CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65 },
                new Product{ ProductId=5, CategoryId=2,ProductName="Mause",UnitPrice=85,UnitsInStock=1 }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);// businessdan gelecek parametre
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;// todo: 2.12
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
