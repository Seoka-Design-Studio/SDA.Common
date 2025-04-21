namespace SDA.Common.Services.Consumers
{
    public abstract class AtlassianIssueConsumer : IConsumer<ErrorRequest>
    {
        public virtual Task Consume(ConsumeContext<ErrorRequest> context)
        {
            return Task.CompletedTask;
        }
    }
}
