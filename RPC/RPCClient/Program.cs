using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace RPCClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("RPC Client");
            string n = args.Length > 0 ? args[0] : "30";
            await InvokeAsync(n);

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }

        private static async Task InvokeAsync(string n)
        {
            using var rpcClient = new RpcClient();

            Console.WriteLine(" [x] Requesting fib({0})", n);
            var response = await rpcClient.CallAsync(n);
            Console.WriteLine(" [.] Got '{0}'", response);
        }
    }
}
