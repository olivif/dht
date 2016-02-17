/// <summary>
/// DHT 2016 
/// </summary>
namespace DHT.Models
{
    using System;

    /// <summary>
    /// Concrete implementation of a piece of data
    /// </summary>
    public class Data : IData
    {
        /// <inheritdoc />
        public string Contents { get; private set; }

        /// <summary>
        /// Creates a data object with contents
        /// </summary>
        /// <param name="contents">The data string contents</param>
        public Data(string contents)
        {
            if (string.IsNullOrEmpty(contents))
            {
                throw new ArgumentNullException("Contents must be non null or empty");
            }

            this.Contents = contents;
        }
    }
}
