/// <summary>
/// DHT 2016 
/// </summary>
namespace DHT.Models
{
    /// <summary>
    /// Contains a piece of data
    /// </summary>
    public interface IData
    {
        /// <summary>
        /// The contents of this piece of data as a string
        /// </summary>
        string Contents { get; }
    }
}
