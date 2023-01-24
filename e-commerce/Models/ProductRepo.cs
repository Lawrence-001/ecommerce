using System.Collections.Generic;

namespace e_commerce.Models
{
    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext context;

        public ProductRepo(AppDbContext context)
        {
            this.context = context;
        }
        public Product AddProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product DeleteProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products;
        }

        public Product UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
