using OpenQbit.Account.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Accounts.BLL.AccountService.Contracts
{
    public interface IAccount
    {

        bool Create(Account account);
        bool DeleteById(int accountId);
        bool Delete(Account account);
        Account Find<AccountT>(Expression<Func<Account, bool>> predicate);

        Account FindById(int accountId);
        List<Account> FindList<Account>(Expression<Func<Account, bool>> predicate);
        List<Account> GetAll<Account>()

        bool Update<Account>(Account obj);

        bool Save();
    }
}
