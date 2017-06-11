using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQbit.Accounts.DAL.DataAccess;
using OpenQubit.Account.Common.Models;

namespace OpenQbit.Accounts.BLL.AccountService
{
    public class DocumentManager
    {
        private Repository _db = new Repository();


        public bool CreateDocument(string templateName, string description, string documentName)
        {
            DocumentType newDocument = new DocumentType();
            return _db.Create<DocumentType>(newDocument);
        }

        public bool RemoveDocument(int documentID) {
            DocumentType newDocument = new DocumentType();
            return _db.Delete<DocumentType>(newDocument);
        }
        public bool RemoveDocument(string documentName) {
            DocumentType newDocumment = new DocumentType();
            return _db.Delete<DocumentType>(newDocumment);
        }
        public DocumentType FindDocument(int id) {
            DocumentType newDocument = new DocumentType();
            return _db.FindList<DocumentType>(id);
        }
    }
}
