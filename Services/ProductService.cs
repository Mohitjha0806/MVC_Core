using System.Security.Cryptography.X509Certificates;

namespace MVC_Core.Services
{
    public class ProductService : IProductService
    {
        public List<string> GetProducts()
        {
            return new List<string> { "Laptop", "Mobile", "Watch" };
        }
    }
}
