namespace EBus.Host2
{
    using EBus.Config;
    using NServiceBus;
    using NServiceBus.Persistence;

    public class EndpointConfig : IConfigureThisEndpoint, AsA_Server, ISpecifyMessageHandlerOrdering
    {
        public void Customize(BusConfiguration configuration)
        {
            configuration.DefaultEndpointConfig();
        }

        public void SpecifyOrder(Order order)
        {
            order.Specify(typeof(MessageHandlerHost2));
        }
    }
}
