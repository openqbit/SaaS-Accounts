using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Accounts.Service.WebAPIService.Models.API
{
    public class ApiTransactionTemplate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int DocumentId { get; set; }

        public string Description { get; set; }
    }
}