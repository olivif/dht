/// <summary>
/// DHT 2016 
/// </summary>
namespace DHT.Routing
{
    using Nodes;
    using Hashing;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Implements the interface for routing over a network
    /// of DHT nodes.
    /// </summary>
    public class Router : IRouter
    {
        /// <summary>
        /// The hasher which will determine how content will be
        /// partitioned across nodes.
        /// </summary>
        private IHasher hasher;

        /// <inheritdoc />
        public List<Node> Nodes { get; private set; }

        /// <summary>
        /// Constructs a router object
        /// </summary>
        /// <param name="hasher">The hashing function used for partioning</param>
        public Router(IHasher hasher)
        {
            this.hasher = hasher;
            this.Nodes = new List<Node>();
        }

        /// <inheritdoc />
        public void RegisterNode(int nodeId, Uri endpoint)
        {
            var node = new Node(nodeId, endpoint);
            this.RegisterNode(node);
        }

        /// <inheritdoc />
        public void RegisterNode(Node node)
        {
            if (node == null)
            {
                throw new ArgumentException("Node is null");
            }

            if (this.Nodes.Any(currentNode => currentNode.NodeId.Equals(node.NodeId)))
            {
                throw new ArgumentException(String.Format("Node with id {0} already registered", node.NodeId));
            }

            if (this.Nodes.Any(currentNode => currentNode.Endpoint.Equals(node.Endpoint)))
            {
                throw new ArgumentException(String.Format("Node running on {0} endpoint already registered", node.Endpoint));
            }

            this.Nodes.Add(node);
        }

        /// <inheritdoc />
        public void Route(string contents)
        {
            throw new NotImplementedException();
        }
    }
}
