/// <summary>
/// DHT 2016 
/// </summary>
namespace DHT.Hashing
{
    using Models;

    /// <summary>
    /// Implements a hashing function 
    /// </summary>
    public interface IHasher
    {
        /// <summary>
        /// Gets a hash value for the provided data 
        /// </summary>
        /// <param name="data">The data to generate a hash for</param>
        /// <returns>An int value</returns>
        int GetHash(IData data);
    }
}
