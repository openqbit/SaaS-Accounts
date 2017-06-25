using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQubit.Account.Common.Models;
using OpenQbit.Accounts.Common.Model;
using System.Linq.Expressions;

namespace OpenQbit.Accounts.BLL.AccountService.Contracts
{
    public interface ICustomerSystem
    {
        bool Create(CustomerSystem customerSystem);
        bool DeleteById(int customerSystemId);
        bool Delete(Customer customerSystem);
        CustomerSystem Find<CustomerSystem>(Expression<Func<CustomerSystem, bool>> predicate);

        CustomerSystem FindById(int customerSystem);
        List<CustomerSystem> FindList<CustomerSystem>(Expression<Func<CustomerSystem, bool>> predicate);
        List<CustomerSystem> GetAll<CustomerSystem>();

        bool Update<CustomerSystem>(CustomerSystem customerSystem);

        bool Save();
    }
}
