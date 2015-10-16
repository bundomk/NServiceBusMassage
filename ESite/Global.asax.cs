using Autofac;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac.Integration.Mvc;

namespace ESite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public ISendOnlyBus bus { get; set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ContainerBuilder builder = new ContainerBuilder();

            // Register your MVC controllers.
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // Set the dependency resolver to be Autofac.
            Autofac.IContainer container = builder.Build();

            BusConfiguration busConfiguration = new BusConfiguration();
            //busConfiguration.EndpointName("Samples.MvcInjection.WebApplication");
            // ExistingLifetimeScope() ensures that IBus is added to the container as well,
            // allowing you to resolve IBus from your own components.
            busConfiguration.UseContainer<AutofacBuilder>(c => c.ExistingLifetimeScope(container));
            busConfiguration.UseSerialization<JsonSerializer>();
            busConfiguration.UsePersistence<InMemoryPersistence>();
            busConfiguration.EnableInstallers();

            bus = Bus.CreateSendOnly(busConfiguration);

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
        }
    }
}
