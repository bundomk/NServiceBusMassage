using EContracts;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEndpointHandler
{
    public class ETestHandler : IHandleMessages<ERemoteMassage>
    {
        public void Handle(ERemoteMassage message)
        {
            Console.WriteLine("Test:" + message.Name);
        }
    }
}
