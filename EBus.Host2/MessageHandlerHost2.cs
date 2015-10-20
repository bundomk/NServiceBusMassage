using EBus.Contracts.Messages;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBus.Host2
{
    public class MessageHandlerHost2 : IHandleMessages<IERemoteMessage>
    {
        public void Handle(IERemoteMessage message)
        {
            Console.WriteLine("Test:" + message.Name + " and type " + message.GetType().Name);
        }
    }
}
