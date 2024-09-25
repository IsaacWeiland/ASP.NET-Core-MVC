namespace ASP.NET_Core_MVC.Models;

public interface IProductRepo
{
    public IEnumerable<Product> GetAllProducts();
}