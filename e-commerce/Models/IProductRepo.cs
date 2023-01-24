using System.Collections.Generic;

namespace e_commerce.Models
{
    public interface IProductRepo
    {
        public Product GetProductById(int id);
        public Product AddProduct(int id);
        public IEnumerable<Product> GetProducts();
        public Product UpdateProduct(Product product);
        public Product DeleteProduct(int id);
    }
}
