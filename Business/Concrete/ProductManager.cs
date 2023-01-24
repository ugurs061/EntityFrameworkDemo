using Business.Abstract;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal; // dışarıdan bir inteface geldiği için Dİ kullanyoruz
        ILogger _logger;
        public ProductManager(IProductDal productDal, ILogger logger)// ctor. IProductDal referansı gelecek. Yani Entity ya da InMemory
        {
            _productDal = productDal;
            _logger = logger;
        }


        // [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            // validation : nesnenin yapısı ile ilgilidir.
            // business codes : iş ihtiyaçlarına uygunluk ile ilgilidir.
            _logger.Log();
            try
            {
                _productDal.Add(product);

                return new SuccessResult(Messages.ProductAdded);
            }
            catch (Exception exception)
            {

                _logger.Log();
            }
            return new ErrorResult();
            
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id)); // id'e göre filtreleme işlemi
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));// min ve max unit price'e göre filtreleme işlemi
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }
    }
}
