﻿/// <summary>
/// DHT 2016 
/// </summary>
namespace DhtNode
{
    using System;
    using System.ServiceModel;

    /// <summary>
    /// An implementation of a node service
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Node : INode
    {
        /// <inheritdoc />
        public int NodeId { get; private set; }

        /// <summary>
        /// Constructs a node using a given id
        /// </summary>
        /// <param name="nodeId">The id of the node</param>
        public Node(int nodeId)
        {
            this.NodeId = nodeId;
        }

        /// <inheritdoc />
        public void ReceiveContent(string content)
        {
            Console.WriteLine("Got content {0}", content);
        }
    }
}
