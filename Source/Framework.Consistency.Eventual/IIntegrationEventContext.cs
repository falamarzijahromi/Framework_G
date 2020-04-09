namespace Framework.Consistency.Contracts.Eventual
{
    public interface IIntegrationEventContext
    {
        void AddEvents(params object[] @events);
    }
}
