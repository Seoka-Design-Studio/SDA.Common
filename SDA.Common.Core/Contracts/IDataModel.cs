namespace SDA.Common.Core.Contracts
{
    public interface IDataModel : IAuditTrail
    {
        public string Id { get; set; }
    }
}
