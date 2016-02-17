/// <summary>
/// DHT 2016 
/// </summary>
namespace DHT.Nodes
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Web;

    /// <summary>
    /// Defines the interface for a node service
    /// </summary>
    [ServiceContract]
    public interface INodeService
    {
        /// <summary>
        /// The identifier of this node
        /// </summary>
        int NodeId { get; }

        /// <summary>
        /// Gets the endpoint the service is running on
        /// </summary>
        [OperationContract]
        [WebGet]
        Uri GetEndpoint();

        /// <summary>
        /// Receives a piece of content and stores it locally or relays 
        /// it to the correct node based on the hash key.
        /// </summary>
        /// <param name="content">The content to be stored</param>
        [OperationContract]
        [WebGet]
        void ReceiveContent(string content);

        /// <summary>
        /// Pings the node
        /// </summary>
        [OperationContract]
        [WebGet]
        void Ping();
    }
}
