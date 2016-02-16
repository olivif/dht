/// <summary>
/// DHT 2016 
/// </summary>
namespace DHT.Hashing
{
    using System;
    using Models;
    
    /// <summary>
    /// An implementation of a hasher which uses the values on a 
    /// circle as a key space.
    /// </summary>
    public class CircleHasher : IHasher
    {
        /// <summary>
        /// The number of degrees on a circle
        /// </summary>
        public const int MaxDegrees = 360;
             
        /// <inheritdoc />
        public int GetHash(IData data)
        {
            var hashCode = data.Contents.GetHashCode();
            var circleHash = Math.Abs(hashCode) % MaxDegrees;

            return circleHash;
        }
    }
}
