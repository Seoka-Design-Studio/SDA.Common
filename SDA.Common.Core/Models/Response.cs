namespace SDA.Common.Core.Models
{
    public class Response<T> : IResponse
        where T : class
    {
        /// <property name="Data">
        /// Gets or sets the data of type <typeparamref name="T"/> associated with the response.
        /// </property>
        /// <typeparam name="T">The type of the data contained in the response.</typeparam>
        public T Data { get; set; }

        /// <property name="Message">
        /// Gets or sets the message associated with the response.
        /// </property>
        public string Message { get; set; }

        [DefaultValue(true)]
        /// <property name="Succeeded">
        /// Indicates whether the response was successful. Default is true.
        /// </property>
        public bool Succeeded { get; set; }
    }
}
