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

        [TestMethod]
        public void CanCreateRouter()
        {
            var basicHasher = new BasicHasher();
            var router = new Router(basicHasher);

            Assert.IsNotNull(router);
        }

        [TestMethod]
        public void CanRegisterNode()
        {
            var basicHasher = new BasicHasher();
            var router = new Router(basicHasher);

            var numberOfNodes = router.Nodes.Count;
            router.RegisterNode(0, FakeEndpoint);

            Assert.AreEqual(numberOfNodes, 0);
            Assert.AreEqual(router.Nodes.Count, 1);
        }

        [TestMethod]
        public void CanRegisterMultipleNodes()
        {
            var basicHasher = new BasicHasher();
            var router = new Router(basicHasher);

            var numberOfNodes = router.Nodes.Count;
            var nodesToRegister = 10;

            for (int nodeIdx = 0; nodeIdx < nodesToRegister; nodeIdx++)
            {
                router.RegisterNode(nodeIdx, FakeEndpoint + nodeIdx);
            }

            Assert.AreEqual(numberOfNodes, 0);
            Assert.AreEqual(router.Nodes.Count, nodesToRegister);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CannotRegisterNodeWithSameId()
        {
            var basicHasher = new BasicHasher();
            var router = new Router(basicHasher);

            router.RegisterNode(0, FakeEndpoint + "1");
            router.RegisterNode(0, FakeEndpoint + "2");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CannotRegisterNodeWithSameEndpoint()
        {
            var basicHasher = new BasicHasher();
            var router = new Router(basicHasher);

            router.RegisterNode(0, FakeEndpoint);
            router.RegisterNode(1, FakeEndpoint);
        }
    }
}
