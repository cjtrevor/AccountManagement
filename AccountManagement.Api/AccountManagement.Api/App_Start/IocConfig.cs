using AccountManagement.Models.Utilities;
using AccountManagement.Services.Implementations;
using AccountManagement.Services.Interfaces;
using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace AccountManagement.Api.App_Start
{
    public class IocConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<CustomerService>().As<ICustomerService>();
            builder.RegisterType<AccountService>().As<IAccountService>();
            builder.RegisterType<TransactionService>().As<ITransactionService>();

            builder.RegisterType<Database>().As<IDatabase>().SingleInstance();
            builder.RegisterType<DataFactory>().As<IDataFactory>().SingleInstance();

            var container = builder.Build();

            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}