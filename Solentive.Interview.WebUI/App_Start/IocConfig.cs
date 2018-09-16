using Autofac;
using Autofac.Integration.Mvc;
using Solentive.Interview.Data;
using Solentive.Interview.Data.Interfaces;
using Solentive.Interview.Model;
using Solentive.Interview.Model.Interfaces;
using Solentive.Interview.Service;
using Solentive.Interview.Service.Interfaces;
using System.Web.Mvc;

namespace Solentive.Interview.WebUI
{
    public static class IocConfig
    {
        public static void ConfigureDependencyInjection()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<LocationService>().As<ILocationService>();
            builder.RegisterType<SeminarService>().As<ISeminarService>();
            builder.RegisterType<TrackService>().As<ITrackService>();
            builder.RegisterType<LevelService>().As<ILevelService>();

            builder.RegisterType<SeminarDbContext>().As<ISeminarDbContext>();
            builder.RegisterType<GenericRepository<Level>>().As<IRepository<Level>>();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}