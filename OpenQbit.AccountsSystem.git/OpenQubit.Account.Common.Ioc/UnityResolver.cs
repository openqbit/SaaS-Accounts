using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace OpenQubit.Account.Common.Ioc
{
    public class UnityResolver
    {
        private static readonly IUnityContainer Container = new UnityContainer();

        private static void Register()
        {
            Container.RegisterType<IBranchResourceAllocationManager, BranchResourceAllocationManager>();
            Container.RegisterType<IBatchManager, BatchManager>();
            Container.RegisterType<IBatchEnrolmentManager, BatchEnrolmentManager>();
            Container.RegisterType<IBranchManager, BranchManager>();
            Container.RegisterType<IEmployeeManager, EmployeeManager>();
            Container.RegisterType<IInstituteManager, InstituteManager>();
            Container.RegisterType<IRepository, Repository>();
            Container.RegisterType<ILogger, Logger>();
        }
    }
}
