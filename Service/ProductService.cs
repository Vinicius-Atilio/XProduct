using api.Entities;
using api.Repository;
using api.Service.IService;

namespace api.Service
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository productRepository;

        public ProductService(){}
        public ProductService(ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<Product> GetProductById(int id)
        {
            return await productRepository.GetProductById(id);
        }
    }
}