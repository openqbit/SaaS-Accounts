using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQubit.Account.Common.Models;
using System.Linq.Expressions;

namespace OpenQbit.Accounts.BLL.AccountService.Contracts
{
    public interface IDocumentType
    {
        bool Create(DocumentType documentType);
        bool DeleteById(int documentTypeId);
        bool Delete(DocumentType documentType);
        DocumentType Find<DocumentType>(Expression<Func<DocumentType, bool>> predicate);

        DocumentType FindById(int documentTypeId);
        List<DocumentType> FindList<DocumentType>(Expression<Func<DocumentType, bool>> predicate);
        List<DocumentType> GetAll<DocumentType>();

        bool Update<DocumentType>(DocumentType documentType);

        bool Save();
    }
}
