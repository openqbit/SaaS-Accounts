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
        bool Create(DocumentType document);
        bool Delete(DocumentType document);
        bool Update(DocumentType document);
        List<DocumentType> GetAll();

        DocumentType FindById(int id);
        bool DeleteById(int id);
        DocumentType Find(Expression<Func<DocumentType, bool>> predicate);
        List<DocumentType> FindList(Expression<Func<DocumentType, bool>> predicate);

        bool Save();
    }
}
