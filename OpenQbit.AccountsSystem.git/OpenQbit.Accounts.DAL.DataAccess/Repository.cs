using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;

using OpenQbit.Accounts.DAL.DataAccess.Contracts;
using OpenQubit.Account.Common.Models;

namespace OpenQbit.Accounts.DAL.DataAccess
{
    public class Repository : IRepository
    {
        private AccountDbContext _db = new AccountDbContext();

        public bool Create<T>(T obj) where T : class
        {
            try
            {
                _db.Set<T>().Add(obj);
                return true;
            }
            catch (Exception db)
            {
                return false;
            }
        }

        public bool Delete<T>(T obj) where T : class
        {
            try
            {
                _db.Set<T>().Remove(obj);
                return true;
            }
            catch (Exception db)
            {
                return false;
            }
        }

        public T Find<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return _db.Set<T>().Where(predicate).FirstOrDefault();
        }

        public T FindById<T>(int id) where T : class
        {
            return _db.Set<T>().Find(id);
        }

        public List<T> FindList<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return _db.Set<T>().Where<T>(predicate).ToList();
        }

        public List<T> GetAll<T>() where T : class
        {
            return _db.Set<T>().ToList();
        }

        public bool Save()
        {
            try
            {
                _db.SaveChanges();
                return true;
            }
            catch (Exception db)
            {
                return false;
            }
        }

        public bool Update<T>(T obj) where T : class
        {
            try
            {
                var dbState = _db.Entry(obj);
                _db.Set<T>().Attach(obj);
                dbState.State = EntityState.Modified;
                return true;
            }
            catch (Exception db)
            {
                return false;
            }
        }
    }
}
