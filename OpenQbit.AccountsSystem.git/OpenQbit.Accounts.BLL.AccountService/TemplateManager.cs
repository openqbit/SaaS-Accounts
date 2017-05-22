using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQbit.Accounts.DAL.DataAccess;
using OpenQubit.Account.Common.Models;

namespace OpenQbit.Accounts.BLL.AccountService
{
    public class TemplateManager
    {
        private Repository _db = new Repository();

        public bool CreateTemplate(string templateName, string description, string documentName)
        {
            TransactionTemplate newTempalet = new TransactionTemplate();
            _db.Create<TransactionTemplate>(newTempalet);
            return false;
        }

        public bool RemoveTemplate(int tempalteId)
        {
            return false;
        }

        public bool RemoveTemplate(string templateName)
        {
            return false;
        }


        public bool AddTemplateDetail(string templateName, string accountName, string crdb, string expression)
        {
            return false;
        }


    }
}
