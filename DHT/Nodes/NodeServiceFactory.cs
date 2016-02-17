/// <summary>
/// DHT 2016 
/// </summary>
namespace DHT.Nodes
{
    using System;
    using System.ServiceModel.Web;

    /// <summary>
    /// Responsible for creating a DHT node service
    /// </summary>
    public class NodeServiceFactory
    {
        /// <summary>
        /// Creates a DHT node service
        /// </summary>
        /// <param name="nodeId">The id of the node</param>
        /// <param name="hostName">Host name, like localhost</param>
        /// <param name="port">Port to run on</param>
        /// <returns>An instance of a dht node</returns>
        public static INodeService CreateNodeService(int nodeId, string hostName, int port)
        {
            var uriString = string.Format("http://{0}:{1}", hostName, port);
            var endpoint = new Uri(uriString);

            return NodeServiceFactory.CreateNodeService(nodeId, endpoint);
        }

        /// <summary>
        /// Creates a DHT node service
        /// </summary>
        /// <param name="nodeId">The id of the node</param>
        /// <param name="endpoint">The endpoint to run on</param>
        /// <returns></returns>
        public static INodeService CreateNodeService(int nodeId, Uri endpoint)
        {
            // TODO Should ping the endpoint and check there is no node existing on that endpoint
            var nodeInstance = new NodeService(nodeId);
            var host = new WebServiceHost(nodeInstance, endpoint);
            host.Open();

            return nodeInstance;
        }
    }
}