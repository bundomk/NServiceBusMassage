using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBus.Config
{
    public static class Convention
    {
        public static void DefaultEndpointConventions(this BusConfiguration config)
        {
            ConventionsBuilder conventions = config.Conventions();
            //conventions.DefiningCommandsAs(t => t.Namespace != null && t.Namespace == "MyNamespace" && t.Namespace.EndsWith("Commands"));
            //conventions.DefiningEventsAs(t => t.Namespace != null && t.Namespace == "MyNamespace" && t.Namespace.EndsWith("Events"));
            //conventions.DefiningMessagesAs(t => t.Namespace != null && t.Namespace == "Messages");
            //conventions.DefiningEncryptedPropertiesAs(p => p.Name.StartsWith("Encrypted"));
            //conventions.DefiningDataBusPropertiesAs(p => p.Name.EndsWith("DataBus"));
            //conventions.DefiningExpressMessagesAs(t => t.Name.EndsWith("Express"));
            //conventions.DefiningTimeToBeReceivedAs(t => t.Name.EndsWith("Expires") ? TimeSpan.FromSeconds(30) : TimeSpan.MaxValue);

            conventions.DefiningMessagesAs(t => t.Namespace != null && t.Namespace.EndsWith(".Messages"));
            conventions.DefiningCommandsAs(t => t.Namespace != null && t.Namespace.EndsWith(".Commands"));
            //conventions.DefiningEventsAs(t => t.Namespace != null && t.Namespace.EndsWith(".Events"));
            //&& t.Namespace.StartsWith("EContracts") 
            
        }
    }
}
