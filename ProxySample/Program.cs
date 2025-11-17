// See https://aka.ms/new-console-template for more information
using ProxySample.Models;

Console.WriteLine("Hello, World!");
Client client = new Client();

Console.WriteLine("Client: Executing the client code with a real subject:");
RealSubject realSubject = new RealSubject();
client.ClientCode(realSubject);

Console.WriteLine();

Console.WriteLine("Client: Executing the same client code with a proxy:");
Proxy proxy = new Proxy(realSubject);
client.ClientCode(proxy);