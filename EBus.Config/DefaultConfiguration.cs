using NServiceBus;
using NServiceBus.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBus.Config
{
    public static class DefaultConfiguration
    {
        public static void DefaultEndpointConfig(this BusConfiguration configuration)
        {
            configuration.UsePersistence<InMemoryPersistence>();
            //configuration.UsePersistence<InMemoryPersistence, StorageType.Sagas>();
            //configuration.UsePersistence<InMemoryPersistence, StorageType.Subscriptions>();
            //configuration.UsePersistence<InMemoryPersistence, StorageType.Timeouts>();
            //configuration.UsePersistence<InMemoryPersistence, StorageType.Outbox>();
            //configuration.UsePersistence<InMemoryPersistence, StorageType.GatewayDeduplication>();
            configuration.UseSerialization<JsonSerializer>();
            configuration.DefaultEndpointConventions();
        }
    }
}
