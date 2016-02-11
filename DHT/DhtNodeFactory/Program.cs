/// <summary>
/// DHT 2016 
/// </summary>
namespace DhtNode
{
    using System;
    using System.ServiceModel.Web;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validating args");

            // Validate number of args
            if (args.Length == 0)
            {
                Console.WriteLine("Invalid number of arguments, please supply a port.");
                Console.WriteLine("Exiting now");
                return;
            }

            // Get arg values
            string portArg = args[0];
            int port = int.Parse(portArg);

            // Set host
            string hostName = "localhost";

            Console.WriteLine("Creating node");

            var node = DhtNodeFactory.NodeFactory.CreateNode(hostName, port);

            Console.WriteLine("Node created");

            Console.ReadLine();
        }
    }
}
