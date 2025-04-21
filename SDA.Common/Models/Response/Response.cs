namespace SDA.Common.Models.Response
{
    /// <summary>
    /// Represents a generic response structure for API operations.
    /// </summary>
    /// <typeparam name="T">The type of the data returned in the response.</typeparam>
    /// <remarks>
    /// This class implements the <see cref="IResponse"/> interface and includes
    /// properties for the response data, a message, and a success indicator.
    /// </remarks>
    public class Response<T> : IResponse
        where T : class
    {
        public T Data { get; set; }
        public string Message { get; set; }

        [DefaultValue(true)]
        public bool Succeeded { get; set; }
    }
}
