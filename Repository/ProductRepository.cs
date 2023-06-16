using api.Entities;
using api.Repository.IRepository;

namespace api.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext dbContext;

        public ProductRepository(AppDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }

        public Task AddProduct(Product product)
        {
            return null;
        }

        public Task DeleteProduct(int id)
        {
            return null;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return null;
        }

        public async Task<Product> GetProductById(int id)
        {
            Product product = await dbContext.Products.FindAsync(id);
            if (product != null){
                return product;
            }
            return null;
        }

        public Task UpdateProduct(Product product)
        {
            return null;
        }
    }
}