using System;

namespace Framework.Consistency.Contracts.Eventual
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class IntegrationEventAttribute : Attribute
    {
        public Guid EventId { get; } = Guid.NewGuid();

        public string Version { get; }

        public string EventName { get; set; }

        public IntegrationEventAttribute(string version)
        {
            Version = version;
        }
    }
}
