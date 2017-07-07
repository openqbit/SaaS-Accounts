using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Accounts.BLL.AccountService.Contracts;
using OpenQubit.Account.Common.Models;
using OpenQbit.Accounts.DAL.DataAccess.Contracts;
using OpenQubit.Account.Common.Utils.Log;
using Microsoft.Practices.Unity;
using System.Linq.Expressions;

namespace OpenQbit.Accounts.BLL.AccountService
{
    public class AccountManager : IAccountManager
    {
        private IRepository _db;
        private ILogger _logger;

        [InjectionConstructor]
        public AccountManager(IRepository repository, ILogger logger)
        {
            this._db = repository;
            this._logger = logger;
        }

        public bool Create(Account account)
        {
            return _db.Create<Account>(account);
        }

        public bool Delete(Account account)
        {
            return _db.Delete<Account>(account);
        }

        public bool DeleteById(int id)
        {
            Account account = _db.Find<Account>(A => A.Id == id);
            return _db.Delete<Account>(account);
        }

        public Account Find(Expression<Func<Account, bool>> predicate)
        {
            return _db.Find<Account>(predicate);
        }

        public Account FindById(int id)
        {
            return _db.Find<Account>(A => A.Id == id);
        }

        public List<Account> FindList(Expression<Func<Account, bool>> predicate)
        {
            return _db.FindList<Account>(predicate);
        }

        public List<Account> GetAll()
        {
            return _db.GetAll<Account>();
        }

        public bool Save()
        {
            return _db.Save();
        }

        public bool Update(Account account)
        {
            return _db.Update<Account>(account);
        }
    }
}
