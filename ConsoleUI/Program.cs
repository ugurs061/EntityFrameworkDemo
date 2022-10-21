using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

ProductManager productManager = new ProductManager(new EfProductDal());
foreach (var product in productManager.GetAllByCategoryId(2))
{
    Console.WriteLine(product.ProductName);
}