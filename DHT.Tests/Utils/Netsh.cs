using System;
using System.Diagnostics;

namespace DHT.Tests.Utils
{
    /// <summary>
    /// A helper class to call netsh commands
    /// </summary>
    public class Netsh
    {
        /// <summary>
        /// Registers an endpoint using the current user and domain name
        /// </summary>
        /// <param name="endpoint">The endpoint to be registered</param>
        public static void RegisterEndpoint(Uri endpoint)
        {
            RegisterEndpoint(endpoint, Environment.UserDomainName, Environment.UserName);
        }

        /// <summary>
        /// Registers an endpoint using the a specified user and domain name
        /// </summary>
        /// <param name="endpoint">The endpoint to be registered</param>
        /// <param name="domain">The domain name</param>
        /// <param name="user">The user</param>
        public static void RegisterEndpoint(Uri endpoint, string domain, string user)
        {
            // Replace localhost with +
            var uri = endpoint.AbsoluteUri.Replace("localhost", "+");

            string args = string.Format(@"http add urlacl url={0} user={1}\{2}", uri, domain, user);

            ProcessStartInfo psi = new ProcessStartInfo("netsh", args);
            psi.Verb = "runas";
            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.UseShellExecute = true;

            Process.Start(psi).WaitForExit();
        }
    }
}
