namespace EBus.Host1
{
    using NServiceBus;
    using NServiceBus.Persistence;
    using EBus.Config;
    using EBus.Host1;

    public class EndpointConfig : IConfigureThisEndpoint, AsA_Server, ISpecifyMessageHandlerOrdering
    {
        public void Customize(BusConfiguration configuration)
        {
            configuration.DefaultEndpointConfig();
        }

        public void SpecifyOrder(Order order)
        {
            order.Specify(typeof(MessageHandlerHost1));
        }
    }
}
