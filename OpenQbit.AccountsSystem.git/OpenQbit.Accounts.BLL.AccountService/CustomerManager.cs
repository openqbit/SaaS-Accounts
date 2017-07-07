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
    public class CustomerManager : ICustomerManager
    {
        private IRepository _db;
        private ILogger _logger;

        [InjectionConstructor]
        public CustomerManager(IRepository repository, ILogger logger)
        {
            this._db = repository;
            this._logger = logger;
        }

        public bool Create(Customer customer)
        {
            return _db.Create<Customer>(customer);
        }

        public bool Delete(Customer customer)
        {
            return _db.Delete<Customer>(customer);
        }

        public bool DeleteById(int id)
        {
            Customer customer = _db.Find<Customer>(A => A.Id == id);
            return _db.Delete<Customer>(customer);
        }

        public Customer Find(Expression<Func<Customer, bool>> predicate)
        {
            return _db.Find<Customer>(predicate);
        }

        public Customer FindById(int id)
        {
            return _db.Find<Customer>(A => A.Id == id);
        }

        public List<Customer> FindList(Expression<Func<Customer, bool>> predicate)
        {
            return _db.FindList<Customer>(predicate);
        }

        public List<Customer> GetAll()
        {
            return _db.GetAll<Customer>();
        }

        public bool Save()
        {
            return _db.Save();
        }

        public bool Update(Customer customer)
        {
            return _db.Update<Customer>(customer);
        }
    }
}
