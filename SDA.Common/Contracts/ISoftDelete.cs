namespace SDA.Common.Contracts
{
    public interface ISoftDelete
    {
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
