namespace SDA.Common.Core.Models
{
    public class ServiceModelBase
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModified { get; set; }
        public DateTime DeletedAt { get; set; }
        public string LastUserModified { get; set; }
        public bool IsActive { get; set; }
    }
}
