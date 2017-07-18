using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Accounts.Service.WebAPIService.Models.API
{
    public class ApiTransaction
    {
        public int Id { get; set; }

        public DateTime TransactionTime { get; set; }

        public string Description { get; set; }

        public string ReferenceTag { get; set; }

        public int TransactionTemplateId { get; set; }
    }
}