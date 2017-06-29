using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Accounts.BLL.AccountService.Contracts;
using OpenQubit.Account.Common.Models;
using OpenQbit.Accounts.DAL.DataAccess.Contracts;
using OpenQubit.Account.Common.Utils.Logs;
using Microsoft.Practices.Unity;
using System.Linq.Expressions;

namespace OpenQbit.Accounts.BLL.AccountService
{
    public class CustomerSystemManager : ICustomerSystemManager
    {
        private IRepository _db;
        private ILogger _logger;

        [InjectionConstructor]
        public CustomerSystemManager(IRepository repository, ILogger logger)
        {
            this._db = repository;
            this._logger = logger;
        }

        public bool Create(CustomerSystem customerSystem)
        {
            return _db.Create<CustomerSystem>(customerSystem);
        }

        public bool Delete(CustomerSystem customerSystem)
        {
            return _db.Delete<CustomerSystem>(customerSystem);
        }

        public bool DeleteById(int id)
        {
            CustomerSystem customerSystem = _db.Find<CustomerSystem>(A => A.Id == id);
            return _db.Delete<CustomerSystem>(customerSystem);
        }

        public CustomerSystem Find(Expression<Func<CustomerSystem, bool>> predicate)
        {
            return _db.Find<CustomerSystem>(predicate);
        }

        public CustomerSystem FindById(int id)
        {
            return _db.Find<CustomerSystem>(A => A.Id == id);
        }

        public List<CustomerSystem> FindList(Expression<Func<CustomerSystem, bool>> predicate)
        {
            return _db.FindList<CustomerSystem>(predicate);
        }

        public List<CustomerSystem> GetAll()
        {
            return _db.GetAll<CustomerSystem>();
        }

        public bool Save()
        {
            return _db.Save();
        }

        public bool Update(CustomerSystem customerSystem)
        {
            return _db.Update<CustomerSystem>(customerSystem);
        }

    }
}
