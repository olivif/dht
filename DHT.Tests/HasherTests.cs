using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DHT.Tests
{
    using Models;
    using Hashing;

    [TestClass]
    public class HasherTests
    {
        #region CircleHasher

        [TestMethod]
        public void CircleHasher_CanCreate()
        {
            var hasher = new CircleHasher();
        }

        [TestMethod]
        public void CircleHasher_CanGetValue()
        {
            var hasher = new CircleHasher();
            var data = new Data("some content");

            var hashValue = hasher.GetHash(data);

            Assert.IsNotNull(hashValue, "Hasher must return a non null value.");
        }

        [TestMethod]
        public void CircleHasher_ValuesEqual()
        {
            var hasher = new CircleHasher();
            var dataA = new Data("some content");
            var dataB = new Data("some content");

            Assert.AreEqual(
                hasher.GetHash(dataA),
                hasher.GetHash(dataB),
                "Hashes should be the same for the same content"
                );
        }

        [TestMethod]
        public void CircleHasher_ValuesDiffer()
        {
            var hasher = new CircleHasher();
            var dataA = new Data("some content");
            var dataB = new Data("some other content");

            Assert.AreNotEqual(
                hasher.GetHash(dataA),
                hasher.GetHash(dataB),
                "Hashes cannot be the same for different content"
                );
        }

        [TestMethod]
        public void CircleHasher_ValuesInRange()
        {
            var hasher = new CircleHasher();
            var sampleValues = new string[] {
                "some content",
                "some other content",
                "yet more content",
              };

            foreach(string value in sampleValues)
            {
                var data = new Data(value);
                var hashValue = hasher.GetHash(data);

                Assert.IsTrue(hashValue >= 0, string.Format("Hash code not in lower range - {0}", hashValue));
                Assert.IsTrue(hashValue <= 360, string.Format("Hash code not in upper range - {0}", hashValue));
            }
        }

        #endregion

    }
}
