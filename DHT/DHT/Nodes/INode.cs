/// <summary>
/// DHT 2016 
/// </summary>
namespace DHT.Nodes
{
    using System;

    /// <summary>
    /// Defines the interface for a node in the system
    /// </summary>
    public interface INode
    {
        /// <summary>
        /// The identifier of this node
        /// </summary>
        int NodeId { get; }

        /// <summary>
        /// The endpoint this node can be reached on
        /// </summary>
        Uri Endpoint { get; }
    }
}
