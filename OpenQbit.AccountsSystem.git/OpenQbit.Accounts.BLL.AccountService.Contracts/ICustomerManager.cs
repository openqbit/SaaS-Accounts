using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQubit.Account.Common.Models;
using System.Linq.Expressions;

namespace OpenQbit.Accounts.BLL.AccountService.Contracts
{
    public interface ICustomerManager
    {
        bool Create(Customer customer);
        bool Delete(Customer customer);
        bool Update(Customer customer);
        List<Customer> GetAll();

        Customer FindById(int id);
        bool DeleteById(int id);
        Customer Find(Expression<Func<Customer, bool>> predicate);
        List<Customer> FindList(Expression<Func<Customer, bool>> predicate);

        bool Save();
    }
}
