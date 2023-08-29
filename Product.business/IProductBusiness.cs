using Product.DTO;

namespace Product.business
{
    public interface IProductBusiness
    {
        Task AddProduct(Domains.Product product);
        Task<IEnumerable<Domains.Product>> GetAllProducts();
        Task<ProductDTO> GetById(int id);
        Task<ProductDTO> GetCustomDataById(int id);
        Task UpdateProduct(Domains.Product product);
    }
}