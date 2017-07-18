using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Accounts.Service.WebAPIService.Models.API
{
    public class ApiDocument
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CustomerId { get; set; }
    }
}