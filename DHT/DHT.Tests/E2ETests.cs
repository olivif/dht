using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DHT.Routing;
using DHT.Hashing;
using DHT.Nodes;
using System.Collections.Generic;
using DHT.Tests.Utils;
using System.Threading;

namespace DHT.Tests
{
    [TestClass]
    public class E2ETests
    {
        public static string LocalHost = "localhost";

        [TestMethod]
        public void CreateRouterAndRegisterNodes()
        {
            // Create router
            var basicHasher = new BasicHasher();
            var router = new Router(basicHasher);

            // Create a few nodes
            var nodes = new List<Node>();
            var nodesToCreate = 4;
            var startPort = 8000;
            for (int nodeId = 0; nodeId < nodesToCreate; nodeId++)
            {
                nodes.Add(new Node(nodeId, this.CreateEndpoint(LocalHost, startPort + nodeId)));
            }

            foreach (var node in nodes)
            {
                // Register endpoints with netsh to avoid permission errors
                Netsh.RegisterEndpoint(node.Endpoint);

                // Create node service
                var nodeService = NodeServiceFactory.CreateNodeService(node.NodeId, node.Endpoint);

                // Register with router
                router.RegisterNode(node.NodeId, node.Endpoint);
            }
        }

        /// <summary>
        /// Creates the full endpoint from a host name and a port
        /// </summary>
        /// <param name="hostName">The host name</param>
        /// <param name="port">The port number</param>
        /// <returns>Full endpoint</returns>
        private Uri CreateEndpoint(string hostName, int port)
        {
            var endpointString = string.Format("http://{0}:{1}", hostName, port);
            var endpoint = new Uri(endpointString);

            return endpoint;
        }
    }
}
