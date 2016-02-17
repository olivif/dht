using DHT.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DHT.Tests
{
    [TestClass]
    public class NodeServiceTests
    {
        /// <summary>
        /// Can create a node service, no exceptions thrown
        /// </summary>
        [TestMethod]
        public void CanCreateNodeService()
        {
            var nodeService = new NodeService(1);

            Assert.IsNotNull(nodeService);
        }

        /// <summary>
        /// Can retrieve the node id property and is set correctly
        /// </summary>
        [TestMethod]
        public void CanRetrieveNodeId()
        {
            var nodeId = 1;
            var nodeService = new NodeService(nodeId);

            Assert.AreEqual(nodeService.NodeId, nodeId);
        }

        /// <summary>
        /// Asserts service can be pinged
        /// </summary>
        [TestMethod]
        public void CanBePinged()
        {
            var nodeId = 1;
            var nodeService = new NodeService(nodeId);

            nodeService.Ping();
        }

        [TestMethod]
        public void CanReceiveContent()
        {
            // TODO
        }
    }
}