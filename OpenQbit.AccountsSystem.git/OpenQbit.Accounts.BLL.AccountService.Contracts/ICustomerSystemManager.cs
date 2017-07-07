using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQubit.Account.Common.Models;
using System.Linq.Expressions;

namespace OpenQbit.Accounts.BLL.AccountService.Contracts
{
    public interface ICustomerSystemManager
    {
        bool Create(CustomerSystem customerSystem);
        bool Delete(CustomerSystem customerSystem);
        bool Update(CustomerSystem customerSystem);
        List<CustomerSystem> GetAll();

        CustomerSystem FindById(int id);
        bool DeleteById(int id);
        CustomerSystem Find(Expression<Func<CustomerSystem, bool>> predicate);
        List<CustomerSystem> FindList(Expression<Func<CustomerSystem, bool>> predicate);

        bool Save();
    }
}
