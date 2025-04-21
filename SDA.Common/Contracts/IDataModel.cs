namespace SDA.Common.Contracts
{
    public interface IDataModel : IAuditTrail
    {
        public string Id { get; set; }
    }
}
