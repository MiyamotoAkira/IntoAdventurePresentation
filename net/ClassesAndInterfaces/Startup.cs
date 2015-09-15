using Owin;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;

namespace ClassesAndInterfaces
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        { 
            var builder = new ContainerBuilder();

            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration(); 
            config.MapHttpAttributeRoutes(); 

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<WeaponMemoryRepository>().As<IWeaponRepository>();
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            appBuilder.UseWebApi(config); 
        }
    }
}

