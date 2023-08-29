using AutoMapper;
using GenericRepositories.Contracts;
using Product.DTO;

namespace Product.business
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IProductRepository _productRepository;
        private IMapper _mapper;
        public ProductBusiness(IProductRepository productRepository, IMapper mapper)
        {
            //_productRepository = productRepository;
            _mapper = mapper;
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public async Task<IEnumerable<Product.Domains.Product>> GetAllProducts()
        {
            try
            {
                return await _productRepository.GetAllAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<ProductDTO> GetById(int id)
        {
            try
            {
                var product =  await _productRepository.GetSingleWhereAsync(x => x.Id == id);
                return _mapper.Map<ProductDTO>(product);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<ProductDTO> GetCustomDataById(int id)
        {
            try
            {
                var data = await _productRepository
                    .SelectColumnsWhereAsync(x => x.Id == id, product => new ProductDTO { Name = product.Name, Price = product.Price});
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task AddProduct(Product.Domains.Product product)
        {
            try
            {
                await _productRepository.AddAsync(product);
                await _productRepository.CommitAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task UpdateProduct(Product.Domains.Product product)
        {
            try
            {

                var existingProduct = await _productRepository.GetSingleWhereAsync(x => x.Id == product.Id);
                existingProduct.Name = product.Name;
                _productRepository.Update(existingProduct);
                await _productRepository.CommitAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}