using DHT.Hashing;
using DHT.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHT.Tests
{
    [TestClass]
    public class RouterTests
    {
        public static string FakeEndpoint = "https://localhost:1000";

        public static Uri FakeEndpointUri = new Uri(FakeEndpoint);

        [TestMethod]
        public void Router_CanCreate()
        {
            var basicHasher = new BasicHasher();
            var router = new Router(basicHasher);

            Assert.IsNotNull(router);
        }

        [TestMethod]
        public void Router_CanRegisterNode()
        {
            var basicHasher = new BasicHasher();
            var router = new Router(basicHasher);

            var numberOfNodes = router.Nodes.Count;
            router.RegisterNode(0, FakeEndpointUri);

            Assert.AreEqual(numberOfNodes, 0);
            Assert.AreEqual(router.Nodes.Count, 1);
        }

        [TestMethod]
        public void Router_CanRegisterMultipleNodes()
        {
            var basicHasher = new BasicHasher();
            var router = new Router(basicHasher);

            var numberOfNodes = router.Nodes.Count;
            var nodesToRegister = 10;

            for (int nodeIdx = 0; nodeIdx < nodesToRegister; nodeIdx++)
            {
                router.RegisterNode(nodeIdx, new Uri(FakeEndpoint + nodeIdx));
            }

            Assert.AreEqual(numberOfNodes, 0);
            Assert.AreEqual(router.Nodes.Count, nodesToRegister);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Router_CannotRegisterNodeWithSameId()
        {
            var basicHasher = new BasicHasher();
            var router = new Router(basicHasher);

            router.RegisterNode(0, new Uri(FakeEndpoint + "1"));
            router.RegisterNode(0, new Uri(FakeEndpoint + "2"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Router_CannotRegisterNodeWithSameEndpoint()
        {
            var basicHasher = new BasicHasher();
            var router = new Router(basicHasher);

            router.RegisterNode(0, FakeEndpointUri);
            router.RegisterNode(1, FakeEndpointUri);
        }
    }
}
