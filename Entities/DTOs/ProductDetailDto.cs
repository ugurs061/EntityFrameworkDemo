using Core.Entities;

namespace Entities.DTOs
{
    // Data Transformation Object (DTO)
    public class ProductDetailDto : IDto // IDto oldupunu belirttik.
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }
    }
}
