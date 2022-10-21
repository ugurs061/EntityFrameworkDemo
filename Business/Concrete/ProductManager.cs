using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal; // dışarıdan bir inteface geldiği için Dİ kullanyoruz

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
