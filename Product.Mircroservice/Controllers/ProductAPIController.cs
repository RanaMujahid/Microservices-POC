using Microsoft.AspNetCore.Mvc;
using Product.business;
using Product.DTO;
using Product.Mircroservice.Grpc_Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Product.Mircroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        private readonly IProductBusiness _productBusiness;
        private readonly DiscountGrpcService _discountGrpcService;

        public IProductBusiness ProductBusiness => _productBusiness;

        public ProductAPIController(IProductBusiness productBusiness, 
            DiscountGrpcService discountGrpcService)
        {
            _productBusiness = productBusiness;
            _discountGrpcService = discountGrpcService;
        }

        [HttpGet]
        public async Task<IEnumerable<Domains.Product>> Get()
        {
            var products = await ProductBusiness.GetAllProducts();
            foreach(var item in products)
            {
                var discount = await _discountGrpcService.GetDiscount(item.Name);
                item.Price -= discount == 0 ? item.Price : (item.Price * discount) / 100;
            } 
            return products;
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<ProductDTO> GetById(int id)
        {
            //var test = HttpContext.Request.Headers["audience"];
            //var test1 = (ClaimsPrincipal)Thread.CurrentPrincipal;
            //test1.Claims.Where(x => x.)
            //return await ProductBusiness.GetById(id);
            return await ProductBusiness.GetCustomDataById(id);
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public async Task Post([FromBody] Domains.Product value)
        {
            try
            {
                await ProductBusiness.AddProduct(value);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("UpdateName")]
        public async Task<Domains.Product> UpdateName([FromBody] Domains.Product value)
        {
            await ProductBusiness.UpdateProduct(value);
            return value;
        }
    }
}
