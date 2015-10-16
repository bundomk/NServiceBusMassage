
namespace EServiceBusEndpoint
{
    using NServiceBus;
    using NServiceBus.Persistence;

    /*
  This class configures this endpoint as a Server. More information about how to configure the NServiceBus host
  can be found here: http://particular.net/articles/the-nservicebus-host
 */
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Server, ISpecifyMessageHandlerOrdering
    {
        public void Customize(BusConfiguration configuration)
        {
            configuration.UsePersistence<InMemoryPersistence, StorageType.Sagas>();
            configuration.UsePersistence<InMemoryPersistence, StorageType.Subscriptions>();
            configuration.UsePersistence<InMemoryPersistence, StorageType.Timeouts>();
            configuration.UsePersistence<InMemoryPersistence, StorageType.Outbox>();
            configuration.UsePersistence<InMemoryPersistence, StorageType.GatewayDeduplication>();

            configuration.UseSerialization<JsonSerializer>();
        }

        public void SpecifyOrder(Order order)
        {
            order.Specify(typeof(EServiceBusRemoteMessagehandler));
        }
    }
}
