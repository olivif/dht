/// <summary>
/// DHT 2016 
/// </summary>
namespace DHT.Hashing
{
    using Models;

    /// <summary>
    /// An basic implementation of a hasher which uses GetHashCode
    /// </summary>
    public class BasicHasher : IHasher
    {
        /// <inheritdoc />
        public int GetHash(IData data)
        {
            return data.Contents.GetHashCode();
        }
    }
}
