/// <summary>
/// DHT 2016 
/// </summary>
namespace DHT.Nodes
{
    using System;
    using System.ServiceModel;

    /// <summary>
    /// An implementation of a node service
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class NodeService : INodeService
    {
        /// <inheritdoc />
        public int NodeId { get; private set; }

        /// <inheritdoc />
        public Uri Endpoint { get; private set; }

        /// <summary>
        /// Constructs a node using a given id
        /// </summary>
        /// <param name="nodeId">The id of the node</param>
        /// <param name="endpoint">The endpoint this node can be reached on</param>
        public NodeService(int nodeId, Uri endpoint)
        {
            this.NodeId = nodeId;
            this.Endpoint = endpoint;
        }

        /// <inheritdoc />
        public void ReceiveContent(string content)
        {
            Console.WriteLine("Got content {0}", content);
        }
    }
}
