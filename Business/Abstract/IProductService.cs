using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id); // id'e göre category filtreleme işlemi
        List<Product> GetByUnitPrice(decimal min, decimal max);// min ve max unit price'e göre filtreleme işlemi
    }
}
