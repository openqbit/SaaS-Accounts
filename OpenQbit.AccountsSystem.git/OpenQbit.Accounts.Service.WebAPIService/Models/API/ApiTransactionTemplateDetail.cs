using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Accounts.Service.WebAPIService.Models.API
{
    public class ApiTransactionTemplateDetail
    {
        public int Id { get; set; }

        public int AccountId { get; set; }

        public string CrDb { get; set; }

        public string AmountExpression { get; set; }
    }
}