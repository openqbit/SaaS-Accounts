using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQubit.Account.Common.Models;
using System.Linq.Expressions;

namespace OpenQbit.Accounts.BLL.AccountService.Contracts
{
    public interface IDocumentManager
    {
        bool Create(Document document);
        bool Delete(Document document);
        bool Update(Document document);
        List<Document> GetAll();

        Document FindById(int id);
        bool DeleteById(int id);
        Document Find(Expression<Func<Document, bool>> predicate);
        List<Document> FindList(Expression<Func<Document, bool>> predicate);

        bool Save();
    }
}
