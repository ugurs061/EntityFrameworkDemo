using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal; // dışarıdan bir inteface geldiği için Dİ kullanyoruz

        public ProductManager(IProductDal productDal)// ctor. IProductDal referansı gelecek. Yani Entity ya da InMemory
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            // business codes
            _productDal.Add(product);
            return new Result(true, "Ürün eklendi");
        }

        public List<Product> GetAll()
        {
            // İş kodları
            // Yetkisi var mı ?
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id); // id'e göre filtreleme işlemi
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);// min ve max unit price'e göre filtreleme işlemi
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
