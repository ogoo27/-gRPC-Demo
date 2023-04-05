using Grpc.Net.Client;
using GrpcService1;

var channel = GrpcChannel.ForAddress("https://localhost:7284");
var client = new Greeter.GreeterClient(channel);

var reply = await client.SayHelloAsync(
    new HelloRequest { Name = "Miracle Ogoo" });
Console.WriteLine("From server: " + reply.Message);