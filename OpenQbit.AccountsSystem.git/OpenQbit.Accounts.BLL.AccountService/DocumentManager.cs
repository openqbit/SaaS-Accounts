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
            Document newDocument = new Document();
            return _db.Create<Document>(newDocument);
        }

        public bool RemoveDocument(int documentID) {
            Document newDocument = new Document();
            return _db.Delete<Document>(newDocument);
        }
        public bool RemoveDocument(string documentName) {
            Document newDocumment = new Document();
            return _db.Delete<Document>(newDocumment);
        }
        public Document FindDocument(int id) {
            Document newDocument = new Document();
            return _db.FindList<Document>(id);
        }
    }
}
