using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using OpenQbit.Accounts.Service.WebAPIService.Models.API;

namespace OpenQbit.Accounts.Service.WebAPIService.Controllers.API
{
    public class TransactionController :  ApiController
    {
        public ApiTransaction Get(int Id)
        {
            ApiTransaction Transaction = new ApiTransaction
            {
                Id = 1,
              //  TransactionTime = "05/07/2017",
                Description = "ddd",
                ReferenceTag = "wev",
                TransactionTemplateId = 2,

            };

            return Transaction;
        }

        public List<ApiTransaction> GetList()
        {
            List<ApiTransaction> Transactionlist = new List<ApiTransaction>();

            ApiTransaction Transaction1 = new ApiTransaction
            {
                Id = 1,
                //  TransactionTime = "05/07/2017",
                Description = "ddd",
                ReferenceTag = "wev",
                TransactionTemplateId = 2,

            };

            ApiTransaction Transaction2 = new ApiTransaction
            {
                Id = 1,
                //  TransactionTime = "05/07/2017",
                Description = "ddd",
                ReferenceTag = "wev",
                TransactionTemplateId = 2,

            };

            Transactionlist.Add(Transaction1);
            Transactionlist.Add(Transaction2);

            return Transactionlist;
        }
    }
}
