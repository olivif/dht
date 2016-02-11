/// <summary>
/// DHT 2016 
/// </summary>
namespace DHT.Nodes
{
    using System.ServiceModel;
    using System.ServiceModel.Web;

    /// <summary>
    /// Defines the interface for a node service
    /// </summary>
    [ServiceContract]
    public interface INode
    {
        /// <summary>
        /// The identifier of this node
        /// </summary>
        int NodeId { get; }

        /// <summary>
        /// Receives a piece of content and stores it locally or relays 
        /// it to the correct node based on the hash key.
        /// </summary>
        /// <param name="content">The content to be stored</param>
        [OperationContract]
        [WebGet]
        void ReceiveContent(string content);
    }
}
