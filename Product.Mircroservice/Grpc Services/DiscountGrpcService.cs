using Discount.Grpc;

namespace Product.Mircroservice.Grpc_Services
{
    public class DiscountGrpcService
    {
        private readonly Discounter.DiscounterClient _discountProtoService;

        public DiscountGrpcService(Discounter.DiscounterClient discountProtoService)
        {
            _discountProtoService = discountProtoService ?? throw new ArgumentNullException(nameof(discountProtoService));
        }

        public async Task<decimal> GetDiscount(string productName)
        {
            var discountRequest = new DiscountRequest { Name = "Ali" };

            var result = await _discountProtoService.GetDiscountAsync(discountRequest);
            return Convert.ToDecimal(result.Discount);
        }
    }
}
