namespace SDA.Common.Core.Contracts
{
    public interface IAuditTrail : ISoftDelete
    {
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool IsActive { get; set; }
        public string LastUserUpdated { get; set; }
    }
}
