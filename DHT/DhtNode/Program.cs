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
            Console.WriteLine("Starting up ...");

            // Validate number of args
            if (args.Length == 0)
            {
                Console.WriteLine("Invalid number of arguments, please supply a port.");
                Console.WriteLine("Exiting now");
                return;
            }

            // Get arg values
            string port = args[0];

            // Construct url 
            var uriString = string.Format("http://localhost:{0}", port);
            var uri = new Uri(uriString);

            Console.WriteLine("Opening host on {0}", uriString);
            using (WebServiceHost host = new WebServiceHost(typeof(Node), uri))
            {
                host.Open();
                Console.WriteLine("Host opened, receiving connections.");

                Console.ReadLine();
            }
        }
    }
}
