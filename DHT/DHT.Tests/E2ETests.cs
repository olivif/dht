using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DHT.Routing;
using DHT.Hashing;
using DHT.Nodes;

namespace DHT.Tests
{
    [TestClass]
    public class E2ETests
    {
        public static string LocalHost = "localhost";

        [TestMethod]
        [Ignore]
        /// Test currently disabled due to access control permissions
        /// when running from VsTest.
        public void CreateRouterAndRegisterNodes()
        {
            // Create router
            var basicHasher = new BasicHasher();
            var router = new Router(basicHasher);

            // Create 2 nodes and register them
            var nodeService1 = NodeServiceFactory.CreateNodeService(0, LocalHost, 1000);
            router.RegisterNode(nodeService1.NodeId, nodeService1.GetEndpoint());

            var nodeService2 = NodeServiceFactory.CreateNodeService(1, LocalHost, 1001);
            router.RegisterNode(nodeService2.NodeId, nodeService2.GetEndpoint());

        }
    }
}
