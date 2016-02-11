/// <summary>
/// DHT 2016 
/// </summary>
namespace DHT.Routing
{
    using Nodes;
    using Hashing;
    using System;
    using System.Collections.Generic;

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
        public List<INode> Nodes { get; private set; }

        /// <summary>
        /// Constructs a router object
        /// </summary>
        /// <param name="hasher">The hashing function used for partioning</param>
        public Router(IHasher hasher)
        {
            this.hasher = hasher;
        }

        /// <inheritdoc />
        public void RegisterNode(int nodeId, string endpoint)
        {
            var node = new Node(nodeId, new Uri(endpoint));
            this.Nodes.Add(node);
        }

        /// <inheritdoc />
        public void Route(string contents)
        {
            throw new NotImplementedException();
        }
    }
}
