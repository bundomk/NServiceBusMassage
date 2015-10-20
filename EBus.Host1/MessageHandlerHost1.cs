using EBus.Contracts.Messages;
using NServiceBus;
using NServiceBus.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBus.Host1
{
    public class MessageHandlerHost1 : IHandleMessages<IEMessage>
    {
        //public IDocumentSession Session { get; set; }

        public void Handle(IEMessage message)
        {
            //Session.Store(new Order
            //{
            //    OrderId = message.OrderId
            //});

            Console.WriteLine("Message id " + message.Id + ", name " + message.Name + " and type " + message.GetType().Name);
            //LogManager
        }
    }
}
