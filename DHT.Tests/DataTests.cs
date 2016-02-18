using DHT.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHT.Tests
{
    [TestClass]
    public class DataTests
    {
        [TestMethod]
        public void Test()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void Data_CanCreateDataObjectWithContents()
        {
            var data = new Data("data");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Data_CannotCreateDataObjectWithNullContents()
        {
            var data = new Data(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Data_CannotCreateDataObjectWithEmptyContents()
        {
            var data = new Data(string.Empty);
        }
    }
}
