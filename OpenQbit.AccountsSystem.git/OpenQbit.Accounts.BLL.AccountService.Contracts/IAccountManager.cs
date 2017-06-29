using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQubit.Account.Common.Models;
using System.Linq.Expressions;

namespace OpenQbit.Accounts.BLL.AccountService.Contracts
{
    public interface IAccountManager
    {
        bool Create(Account account);
        bool Delete(Account account);
        bool Update(Account account);
        List<Account> GetAll();

        Account FindById(int id);
        bool DeleteById(int id);
        Account Find(Expression<Func<Account, bool>> predicate);
        List<Account> FindList(Expression<Func<Account, bool>> predicate);

        bool Save();

    }
}
