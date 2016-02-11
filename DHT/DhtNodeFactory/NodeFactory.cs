/// <summary>
/// DHT 2016 
/// </summary>
namespace DhtNodeFactory
{
    using DhtNode;
    using System;
    using System.ServiceModel.Web;

    /// <summary>
    /// Responsible for creating a DHT node
    /// </summary>
    public class NodeFactory
    {
        /// <summary>
        /// Creates a DHT node 
        /// </summary>
        /// <param name="nodeId">The id of the node</param>
        /// <param name="hostName">Host name, like localhost</param>
        /// <param name="port">Port to run on</param>
        /// <returns>An instance of a dht node</returns>
        public static INode CreateNode(int nodeId, string hostName, int port)
        {
            var uriString = string.Format("http://{0}:{1}", hostName, port);
            var uri = new Uri(uriString);

            var nodeInstance = new Node(nodeId);
            using (WebServiceHost host = new WebServiceHost(nodeInstance, uri))
            {
                host.Open();
            }

            return nodeInstance;
        }
    }
}