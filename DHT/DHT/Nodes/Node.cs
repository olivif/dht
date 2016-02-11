/// <summary>
/// DHT 2016 
/// </summary>
namespace DHT.Nodes
{
    using System;

    /// <summary>
    /// Represents the logical structure of a node in the system
    /// </summary>
    public class Node : INode
    {
        /// <inheritdoc />
        public int NodeId { get; private set; }

        /// <inheritdoc />
        public Uri Endpoint { get; private set; }

        /// <summary>
        /// Constructs a node using a given id and endpoint
        /// </summary>
        /// <param name="nodeId">The id of the node</param>
        /// <param name="endpoint">The endpoint this node can be reached on</param>
        public Node(int nodeId, Uri endpoint)
        {
            this.NodeId = nodeId;
            this.Endpoint = endpoint;
        }
    }
}
