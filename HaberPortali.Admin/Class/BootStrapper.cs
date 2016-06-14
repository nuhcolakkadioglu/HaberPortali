using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using HaberPortali.Core.Repository;
using HaberPortali.Core.Infrastructure;

namespace HaberPortali.Admin.Class
{
    public class BootStrapper
    {
        public static void RunConfig()
        {
            BuildAutofac();
        }

        private static void BuildAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<HaberRepository>().As<IHaberRepository>();
            builder.RegisterType<KullaniciRepository>().As<IKullaniciRepository>();
            builder.RegisterType<ResimRepository>().As<IResimRepository>();
            builder.RegisterType<RolRepository>().As<IRolRepository>();
            builder.RegisterType<KategoriRepository>().As<IKategoriRepository>();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}