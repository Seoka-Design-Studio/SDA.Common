using System.Text;

namespace SDA.Common.Services.Requests
{

    /// <summary>
    /// Represents an error that occurred during the processing of an HTTP request.
    /// </summary>
    public class ErrorRequest
    {
        /// <summary>
        /// Gets or sets the request path where the error occurred.
        /// </summary>
        public required string Path { get; set; }

        /// <summary>
        /// Gets or sets the exception that was thrown during the request processing.
        /// </summary>
        public required Exception Error { get; set; }

        /// <summary>
        /// Gets or sets the HTTP method (e.g., GET, POST) of the request.
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// Returns a string that represents the current <see cref="ErrorRequest"/>.
        /// </summary>
        /// <returns>
        /// A string containing the request path, method, and detailed exception information.
        /// </returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Endpoint: {Path}");

            if (!string.IsNullOrEmpty(Method))
            {
                sb.AppendLine($"Request Method: {Method}");
            }
            sb.AppendLine($"Exception: {Error}");

            return sb.ToString();
        }

    }
}