using api.Entities;

namespace api.Service.IService;
public interface IProductService
{
    Task<Product> GetProductById(int id);
}
