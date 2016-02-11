/// <summary>
/// DHT 2016 
/// </summary>
namespace DHT.Routing
{
    /// <summary>
    /// Defines the interface for a router
    /// </summary>
    public interface IRouter
    {
        /// <summary>
        /// Routes a piece of content to the correct DHT node
        /// </summary>
        /// <param name="content">The content to be sent</param>
        void Route(string content);
    }
}
