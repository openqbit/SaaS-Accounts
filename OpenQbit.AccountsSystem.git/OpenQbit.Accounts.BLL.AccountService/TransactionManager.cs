using OpenQbit.Accounts.DAL.DataAccess;
using OpenQubit.Account.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Accounts.BLL.AccountService
{
    class TransactionManager
    {
        private DAL.DataAccess.Repository _db = new Repository();

        public bool RecoardTransaction(Transaction newTransaction)
        {
          //  Transaction newTransaction = new Transaction();
            return _db.Create<Transaction>(newTransaction);

        }

        public bool RemoveTemplate(int tempalteId)
        {
            Transaction newTransaction = new Transaction();
            return _db.Create<Transaction>(newTransaction);
        }

        public bool RemoveTemplate(string templateName)
        {
            Transaction newTransaction = new Transaction();
            return _db.Create<Transaction>(newTransaction);
        }

        public TransactionTemplate FindTemplate(int id)
        {
            Transaction newTransaction = new Transaction();
            return _db.Find<Transaction>(id);
        }

        ////TransactionTime,Description,ReferenceTag,TransactionTemplateId
        public bool AddTemplateDetail(string templateName, string accountName, string crdb, string expression)
        {
            Transaction newTransaction = new Transaction();
            return _db.Create<Transaction>(newTransaction);

        }
    }
}

