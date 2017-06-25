using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQubit.Account.Common.Models;
using System.Linq.Expressions;

namespace OpenQbit.Accounts.BLL.AccountService.Contracts
{
    public interface ITransaction
    {
        bool Create(Transaction transaction);
        bool DeleteById(int transactionId);
        bool Delete(Transaction transaction);
        Transaction Find<Transaction>(Expression<Func<Transaction, bool>> predicate);

        Transaction FindById(int transactionId);
        List<Transaction> FindList<Transaction>(Expression<Func<Transaction, bool>> predicate);
        List<Transaction> GetAll<Transaction>();

        bool Update<Transaction>(Transaction transaction);

        bool Save();
    }
}
