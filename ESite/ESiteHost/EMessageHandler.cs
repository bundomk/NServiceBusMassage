using EContracts;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESiteHost
{
    public class EMessageHandler : IHandleMessages<EMessage>
    {
        //public IDocumentSession Session { get; set; }

        public void Handle(EMessage message)
        {
            //Session.Store(new Order
            //{
            //    OrderId = message.OrderId
            //});

            Console.WriteLine("Message id " + message.Id + " and name " + message.Name);
        }
    }
}
