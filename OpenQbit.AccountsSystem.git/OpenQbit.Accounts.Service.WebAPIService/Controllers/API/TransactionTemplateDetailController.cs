using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using OpenQbit.Accounts.Service.WebAPIService.Models.API;

namespace OpenQbit.Accounts.Service.WebAPIService.Controllers.API
{
    public class TransactionTemplateDetailController :ApiController
    {
        public ApiTransactionTemplateDetail Get(int Id)
        {
            ApiTransactionTemplateDetail TransactionTemplateDetail = new ApiTransactionTemplateDetail
            {
                Id = 1,
                AccountId = 2,
                CrDb = "Abc",
                AmountExpression = "def",

            };

            return TransactionTemplateDetail;
        }

        public List<ApiTransactionTemplateDetail> GetList()
        {
            List<ApiTransactionTemplateDetail> TransactionTemplateDetaillist = new List<ApiTransactionTemplateDetail>();

            ApiTransactionTemplateDetail TransactionTemplateDetail2 = new ApiTransactionTemplateDetail
            {
                Id = 1,
                AccountId = 2,
                CrDb = "Abc",
                AmountExpression = "def",

            };

            ApiTransactionTemplateDetail account2 = new ApiTransactionTemplateDetail
            {
                Id = 1,
                AccountId = 2,
                CrDb = "Abc",
                AmountExpression = "def",

            };

            TransactionTemplateDetaillist.Add(TransactionTemplateDetail2);
            TransactionTemplateDetaillist.Add(account2);

            return TransactionTemplateDetaillist;
        }
    }
}
