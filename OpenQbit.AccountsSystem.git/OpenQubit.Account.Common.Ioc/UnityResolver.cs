using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using OpenQubit.Account.Common.Models;
using OpenQbit.Accounts.BLL.AccountService.Contracts;
using OpenQbit.Accounts.BLL.AccountService;

namespace OpenQubit.Account.Common.Ioc
{
    public class UnityResolver
    {
        private static readonly IUnityContainer Container = new UnityContainer();

        private static void Register()
        {
            Container.RegisterType<IAccountManager, AccountManager>();
            Container.RegisterType<ICustomerManager, CustomerManager>();
            Container.RegisterType<ICustomerSystemManager, CustomerSystemManager>();
            Container.RegisterType<IDocumentManager, DocumentManager>();
            Container.RegisterType<ITransactionManager, ITransactionManager>();
            Container.RegisterType<ITransactionTemplateManager, TemplateManager>();
            
        }
    }
}
