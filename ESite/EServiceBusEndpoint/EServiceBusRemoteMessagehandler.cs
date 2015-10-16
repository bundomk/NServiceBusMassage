using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EContracts;

namespace EServiceBusEndpoint
{
    public class EServiceBusRemoteMessagehandler : IHandleMessages<ERemoteMassage>
    {
        public void Handle(ERemoteMassage message)
        {
            Console.WriteLine("Message Id = " + message.Id + ", and message name " + message.Name);
        }
    }
}
