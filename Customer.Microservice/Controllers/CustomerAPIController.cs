using Customer.DAL.IRepositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Customer.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAPIController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerAPIController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Domains.Customer>> Get()
        {
            return await _customerRepository.GetAll();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public async Task<Domains.Customer> Post([FromBody] Domains.Customer value)
        {
            try
            {
                await _customerRepository.Add(value);
                await _customerRepository.Commit();
                return value;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
