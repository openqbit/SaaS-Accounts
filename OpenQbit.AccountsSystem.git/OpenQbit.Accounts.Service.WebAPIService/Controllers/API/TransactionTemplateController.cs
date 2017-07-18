using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using OpenQbit.Accounts.Service.WebAPIService.Models.API;

namespace OpenQbit.Accounts.Service.WebAPIService.Controllers.API
{
    public class TransactionTemplateController : ApiController
    {
        public ApiTransactionTemplate Get(int Id)
        {
            ApiTransactionTemplate Account = new ApiTransactionTemplate
            {
                Id = 1,
                Name = "Abc",
                DocumentId = 1,
                Description = "def",

            };

            return Account;
        }

        public List<ApiTransactionTemplate> GetList()
        {
            List<ApiTransactionTemplate> TransactionTemplatelist = new List<ApiTransactionTemplate>();

            ApiTransactionTemplate TransactionTemplate1 = new ApiTransactionTemplate
            {
                Id = 1,
                Name = "Abc",
                DocumentId = 1,
                Description = "def",

            };

            ApiTransactionTemplate TransactionTemplate2 = new ApiTransactionTemplate
            {
                Id = 1,
                Name = "Abc",
                DocumentId = 1,
                Description = "def",
            };

            TransactionTemplatelist.Add(TransactionTemplate1);
            TransactionTemplatelist.Add(TransactionTemplate2);

            return TransactionTemplatelist;
        }
    }
}
}