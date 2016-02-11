/// <summary>
/// DHT 2016 
/// </summary>
namespace DHT.Routing
{
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
        List<int> Nodes { get; }

        /// <summary>
        /// Registers a node id
        /// </summary>
        /// <param name="nodeId"></param>
        [OperationContract]
        [WebGet]
        void RegisterNode(int nodeId);

        /// <summary>
        /// Routes a piece of content to the correct DHT node
        /// </summary>
        /// <param name="contents">The content to be sent</param>
        [OperationContract]
        [WebGet]
        void Route(string contents);
    }
}
