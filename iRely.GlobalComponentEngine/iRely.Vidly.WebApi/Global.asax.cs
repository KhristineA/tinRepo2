using Autofac;
using Autofac.Integration.WebApi;
using iRely.Common.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace iRely.Vidly.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            #region Dependency Injection Configuration - Autofac
            // Autofac Configuration
            var config = GlobalConfiguration.Configuration;
            var builder = new ContainerBuilder();
            // Register Api Controller/s
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            // Register Api Web Api Filter/s
            builder.RegisterWebApiFilterProvider(config);
            // Register Autofac Modules
            builder.RegisterModule(new RepositoryModule());
            builder.RegisterModule(new BusinessLayerModule());
            // Build IOC Container
            var container = builder.Build();
            // Resolve Dependency
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            #endregion

            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
        }
    }
}
