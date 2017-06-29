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
using OpenQubit.Account.Common.Models;

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


        public bool Create(DocumentType document)
        {
            return _db.Create<DocumentType>(document);
        }


        public bool Delete(DocumentType document)
        {
            return _db.Delete<DocumentType>(document);
        }

        public bool DeleteById(int id)
        {
            DocumentType document = _db.Find<DocumentType>(A => A.Id == id);
            return _db.Delete<DocumentType>(document);
        }


        public DocumentType Find(Expression<Func<DocumentType, bool>> predicate)
        {
            return _db.Find<DocumentType>(predicate);
        }

        public DocumentType FindById(int id)
        {
            return _db.Find<DocumentType>(A => A.Id == id);
        }

        public List<DocumentType> FindList(Expression<Func<DocumentType, bool>> predicate)
        {
            return _db.FindList<DocumentType>(predicate);
        }

        public List<DocumentType> GetAll()
        {
            return _db.GetAll<DocumentType>();
        }

        public bool Save()
        {
            return _db.Save();
        }


        public bool Update(DocumentType document)
        {
            return _db.Update<DocumentType>(document);
        }

        
    }
}
