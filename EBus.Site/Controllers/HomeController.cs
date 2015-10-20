using EBus.Contracts.Commands;
using EBus.Contracts.Messages;
using EBus.Site.Helpers;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EBus.Site.Controllers
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
            bus.Send<IEMessage>(r => { r.Id = Guid.NewGuid(); r.Name = "IEMessage"; r.Description = "Desc desc"; });
            bus.Send<IERemoteMessage>(r => { r.Id = Guid.NewGuid(); r.Name = "IERemoteMessage"; });
            bus.Send<IECommand>(r => { r.Id = Guid.NewGuid(); r.Name = "IECommand"; });
            
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