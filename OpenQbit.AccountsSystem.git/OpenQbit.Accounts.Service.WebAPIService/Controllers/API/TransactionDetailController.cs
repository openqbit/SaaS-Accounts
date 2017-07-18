using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using OpenQbit.Accounts.Service.WebAPIService.Models.API;

namespace OpenQbit.Accounts.Service.WebAPIService.Controllers.API
{
    public class TransactionDetailController :ApiController
    {
        public ApiTransactionDetail Get(int Id)
        {
            ApiTransactionDetail TransactionDetail = new ApiTransactionDetail
            {
                Id = 1,
                AccountId = 1,
                TransactionId = 1,
                CrAmount =2.00,
                DbAmount= 3.00,

            };

            return TransactionDetail;
        }

        public List<ApiTransactionDetail> GetList()
        {
            List<ApiTransactionDetail> TransactionDetailList = new List<ApiTransactionDetail>();

            ApiTransactionDetail TransactionDetail1 = new ApiTransactionDetail
            {
                Id = 1,
                AccountId = 1,
                TransactionId = 1,
                CrAmount = 2.00,
                DbAmount = 3.00,

            };

            ApiTransactionDetail TransactionDetail2 = new ApiTransactionDetail
            {
                Id = 1,
                AccountId = 1,
                TransactionId = 1,
                CrAmount = 2.00,
                DbAmount = 3.00,

            };

            TransactionDetailList.Add(TransactionDetail1);
            TransactionDetailList.Add(TransactionDetail2);

            return TransactionDetailList;
        }
    }
}
