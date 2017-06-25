using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQubit.Account.Common.Models;
using System.Linq.Expressions;

namespace OpenQbit.Accounts.BLL.AccountService.Contracts
{
    public interface ICustomer
    {
        bool Create(Customer customer);
        bool DeleteById(int customerId);
        bool Delete(Customer customer);
        Customer Find<Customer>(Expression<Func<Customer, bool>> predicate);

        Customer FindById(int customerId);
        List<Customer> FindList<Customer>(Expression<Func<Customer, bool>> predicate);
        List<Customer> GetAll<CustomerT>();

        bool Update<Customer>(Customer customer);

        bool Save();
    }
}
