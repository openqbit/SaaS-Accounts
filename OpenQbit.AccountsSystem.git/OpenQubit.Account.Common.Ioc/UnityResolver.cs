using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using OpenQbit.Accounts.BLL.AccountService.Contracts;
using OpenQbit.Accounts.BLL.AccountService;
using OpenQbit.Accounts.DAL.DataAccess.Contracts;
using OpenQbit.Accounts.DAL.DataAccess;
using OpenQubit.Account.Common.Utils.Log;

namespace OpenQubit.Account.Common.Ioc
{
    public static class UnityResolver
    {
        private static readonly IUnityContainer container = new UnityContainer();

        private static void Register()
        {
            container.RegisterType<IRepository, Repository>();
            container.RegisterType<ILogger, Logger>();
            container.RegisterType<IAccountManager, AccountManager>();
            container.RegisterType<ICustomerManager, CustomerManager>();
            container.RegisterType<ICustomerSystemManager, CustomerSystemManager>();
            container.RegisterType<IDocumentManager, DocumentManager>();
        }

        public static T Resolve<T>()
        {
            T defaultT = default(T);
            var resolved = container.Resolve<T>();
            return (resolved == null) ? defaultT : resolved;
        }

        public static IUnityContainer GetContainer()
        {
            return container;
        }
    }
}
