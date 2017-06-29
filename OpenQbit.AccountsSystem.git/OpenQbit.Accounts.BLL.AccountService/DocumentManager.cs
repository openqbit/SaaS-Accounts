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
    public class DocumentManager :IDocumentManager
    {
        private IRepository _db;
        private ILogger _logger;

        [InjectionConstructor]
        public DocumentManager(IRepository repository, ILogger logger)
        {
            this._db = repository;
            this._logger = logger;
        }

        public bool Create(Document document)
        {
            return _db.Create<Document>(document);
        }

        public bool Delete(Document document)
        {
            return _db.Delete<Document>(document);
        }

        public bool DeleteById(int id)
        {
            Document document = _db.Find<Document>(A => A.Id == id);
            return _db.Delete<Document>(document);
        }

        public Document Find(Expression<Func<Document, bool>> predicate)
        {
            return _db.Find<Document>(predicate);
        }

        public Document FindById(int id)
        {
            return _db.Find<Document>(A => A.Id == id);
        }

        public List<Document> FindList(Expression<Func<Document, bool>> predicate)
        {
            return _db.FindList<Document>(predicate);
        }

        public List<Document> GetAll()
        {
            return _db.GetAll<Document>();
        }

        public bool Save()
        {
            return _db.Save();
        }

        public bool Update(Document document)
        {
            return _db.Update<Document>(document);
        }
    }
}
