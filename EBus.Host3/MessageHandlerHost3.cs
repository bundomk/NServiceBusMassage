using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBus.Contracts.Commands;

namespace EBus.Host3
{
    public class MessageHandlerHost3 : IHandleMessages<IECommand>
    {
        public void Handle(IECommand message)
        {
            Console.WriteLine("Message Id = " + message.Id + ", name " + message.Name + " and type " + message.GetType().Name);
        }
    }
}
