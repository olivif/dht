/// <summary>
/// DHT 2016 
/// </summary>
namespace DhtNode
{
    using System;

    /// <summary>
    /// An implementation of a node service
    /// </summary>
    public class Node : INode
    {
        /// <inheritdoc />
        public void ReceiveContent(string content)
        {
            Console.WriteLine("Got content {0}", content);
        }
    }
}
