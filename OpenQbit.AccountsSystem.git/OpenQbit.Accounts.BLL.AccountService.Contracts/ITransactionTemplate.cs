using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQubit.Account.Common.Models;
using System.Linq.Expressions;

namespace OpenQbit.Accounts.BLL.AccountService.Contracts
{
    public interface ITransactionTemplate
    {
        bool Create(TransactionTemplate transactionTemplate);
        bool DeleteById(int transactionTemplateId);
        bool Delete(TransactionTemplate transactionTemplate);
        TransactionTemplate Find<TransactionTemplate>(Expression<Func<TransactionTemplate, bool>> predicate);

        TransactionTemplate FindById(int transactionId);
        List<TransactionTemplate> FindList<TransactionTemplate>(Expression<Func<TransactionTemplate, bool>> predicate);
        List<TransactionTemplate> GetAll<TransactionTemplate>();

        bool Update<TransactionTemplate>(TransactionTemplate transaction);

        bool Save();
    }
}
