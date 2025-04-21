namespace SDA.Common.Contracts
{
    public interface IResponse
    {
        public string Message { get; set; }
        public bool Succeeded { get; set; }
    }
}
