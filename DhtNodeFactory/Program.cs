/// <summary>
/// DHT 2016 
/// </summary>
namespace DhtNode
{
    using DHT.Nodes;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validating args");

            // Validate number of args
            if (args.Length != 2)
            {
                Console.WriteLine("Invalid number of arguments, please supply a port and a node id");
                Console.WriteLine("Exiting now");
                return;
            }

            // Get arg values
            int port = int.Parse(args[0]);
            int nodeId = int.Parse(args[1]);

            // Set host
            string hostName = "localhost";

            Console.WriteLine("Creating node {0}", nodeId);

            var node = NodeServiceFactory.CreateNodeService(nodeId, hostName, port);

            Console.WriteLine("Node created");

            Console.ReadLine();
        }
    }
}
