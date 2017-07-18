using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Accounts.Service.WebAPIService.Models.API
{
    public class ApiTransactionDetail
    {
        public int Id { get; set; }

        public int AccountId { get; set; }

        public int TransactionId { get; set; }

     
        public double CrAmount { get; set; }

        
        public double DbAmount { get; set; }
    }
}