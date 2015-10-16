using EContracts;
using ESite.Helpers;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ESite.Controllers
{
    public class HomeController : Controller
    {
        IBus bus;

        public HomeController(IBus bus)
        {
            this.bus = bus;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //bus.Send("Samples.Mvc.Endpoint", new EMessage() { Id = Guid.NewGuid(), Name = "Test", Description = "Is it work?" });
            bus.Send(ConfigHelper.GetEndpointFromApp("ESiteHost"), new EMessage() { Id = Guid.NewGuid(), Name = "Test", Description = "Is it work?" });
            bus.Send(ConfigHelper.GetEndpointFromApp("EServiceBusEndpoint"), new ERemoteMassage() { Id = Guid.NewGuid(), Name = "Samo za Dragan" });
            bus.Send(ConfigHelper.GetEndpointFromApp("EEndpointHandler"), new ERemoteMassage() { Id = Guid.NewGuid(), Name = "Samo za Antonija" });
            
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
           // bus.Publish();

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}