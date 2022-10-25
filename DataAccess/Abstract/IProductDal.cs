using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>// product için yapılandırıldı
    {
        List<ProductDetailDto> GetProductDetails(); // ürünün detaylarını getir
    }
}
// Code Rafactoring