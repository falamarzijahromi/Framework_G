using System;

namespace Framework.Consistency.Contracts.Eventual
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class ForIntegrationEventAttribute : Attribute
    {
        public Type EventType { get; }
        public string EventVersion { get; }
        public string EventName { get; }

        public ForIntegrationEventAttribute(Type eventType, string eventVersion)
            : this(eventType, eventVersion, default) { }

        public ForIntegrationEventAttribute(string eventName, string eventVersion)
        : this(default, eventVersion, eventName) { }

        private ForIntegrationEventAttribute(Type eventType, string eventVersion, string eventName)
        {
            EventType = eventType;
            EventVersion = eventVersion;
            EventName = eventName;
        }
    }
}
