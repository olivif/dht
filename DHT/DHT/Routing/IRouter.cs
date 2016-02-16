/// <summary>
/// DHT 2016 
/// </summary>
namespace DHT.Routing
{
    using Nodes;
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Web;

    /// <summary>
    /// Defines the interface for a router
    /// </summary>
    [ServiceContract]
    public interface IRouter
    {
        /// <summary>
        /// Currently registered nodes in the system
        /// </summary>
        List<Node> Nodes { get; }

        /// <summary>
        /// Registers a node
        /// </summary>
        /// <param name="nodeId">Node id</param>
        /// <param name="endpoint">Endpoint of the node</param>
        [OperationContract]
        [WebGet]
        void RegisterNode(int nodeId, Uri endpoint);

        /// <summary>
        /// Routes a piece of content to the correct DHT node
        /// </summary>
        /// <param name="contents">The content to be sent</param>
        [OperationContract]
        [WebGet]
        void Route(string contents);
    }
}
