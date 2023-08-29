using Grpc.Core;
using Discount.Grpc;

namespace Discount.Grpc.Services
{
    public class DiscountService : Discounter.DiscounterBase
    {
        private readonly ILogger<DiscountService> _logger;
        public DiscountService(ILogger<DiscountService> logger)
        {
            _logger = logger;
        }

        public override Task<DiscountResponse> GetDiscount(DiscountRequest request, ServerCallContext context)
        {
            return Task.FromResult(new DiscountResponse
            {
                Discount = "10.00"
            });
        }
    }
}
