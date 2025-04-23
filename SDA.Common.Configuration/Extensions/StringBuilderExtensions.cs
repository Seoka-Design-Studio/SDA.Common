using System.Text;

namespace SDA.Common.Configuration.Extensions
{
    /// <summary>
    /// Provides extension methods for the <see cref="StringBuilder"/> class.
    /// </summary>
    public static class StringBuilderExtensions
    {
        /// <summary>
        /// Appends detailed information about an <see cref="Exception"/> to the <see cref="StringBuilder"/>.
        /// </summary>
        /// <param name="sb">The <see cref="StringBuilder"/> instance to append to.</param>
        /// <param name="exception">The <see cref="Exception"/> to append details from.</param>
        /// <returns>The updated <see cref="StringBuilder"/> instance.</returns>
        public static StringBuilder AppendError(this StringBuilder sb, Exception exception)
        {
            ArgumentNullException.ThrowIfNull(sb);
            ArgumentNullException.ThrowIfNull(exception);
            sb.AppendFormat("Error: {0}", exception.Message);
            if (exception.InnerException != null)
            {
                sb.AppendLine();
                sb.AppendFormat("Detailed Message: {0}", exception.InnerException.Message);
            }
            return sb;
        }
    }
}
