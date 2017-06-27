using OpenQbit.Accounts.DAL.DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using OpenQbit.Accounts.BLL.AccountService.Contracts;
using OpenQubit.Account.Common.Models;
using OpenQubit.Account.Common.Utils.Logs;

using Microsoft.Practices.Unity;
namespace OpenQbit.Accounts.BLL.AccountService
{
    class AccountManager:IAccount
    {

        private IRepository _db;
        private ILogger _logger;


        [InjectionConstructor]
        public AccountManager(IRepository repository, ILogger logger)
        {
            this._logger = logger;
            _db = repository;
        }

        public bool Create(Account account)
        {
            return _db.Create(account);
        }

        public bool DeleteById(int accountId)
        {
            Account account = _db.Find<Account>(A => A.Id == accountId);
            return _db.Delete(account);
        }

        public bool Delete(Account account)
        {
            return _db.Delete(account);
        }

        public Account Find<AccountT>(Expression<Func<Account, bool>> predicate)
        {
            return _db.Find(predicate);
        }

        public Account FindById(int accountId)
        {
            return _db.Find<Account>(A => A.Id == accountId);
        }

        public List<Account> FindList<Account>(Expression<Func<Account, bool>> predicate)
        {
            return _db.FindList<Account>(A => A.);
        }

        public List<Account> GetAll<Account>()
        {
            return _db.GetAll<>();
        }

        public bool Update<Account>(Account obj)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
