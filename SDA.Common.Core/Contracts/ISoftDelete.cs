namespace SDA.Common.Core.Contracts
{
    public interface ISoftDelete
    {
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
