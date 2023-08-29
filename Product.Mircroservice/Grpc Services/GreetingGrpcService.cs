using Discount.Microservice;

namespace Product.Mircroservice.Grpc_Services
{
    public class GreetingGrpcService
    {
        private readonly Greeter.GreeterClient _grpcClient;
        public GreetingGrpcService(Greeter.GreeterClient greeterClient)
        {
            _grpcClient = greeterClient;
        }

        public async Task<string> SayHello(string name)
        {
            var greetingRequest = new HelloRequest { Name = name };
            var helloResult = await _grpcClient.SayHelloAsync(greetingRequest);
            return helloResult.Message;
        }
    }
}
