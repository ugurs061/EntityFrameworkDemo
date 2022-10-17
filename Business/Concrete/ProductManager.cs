using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)// ctor. IProductDal referansı gelecek. Yani Entity ya da InMemory
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // İş kodları
            // Yetkisi var mı ?
            return _productDal.GetAll();
        }
    }
}
