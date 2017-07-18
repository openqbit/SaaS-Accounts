using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using OpenQbit.Accounts.Service.WebAPIService.Models.API;

namespace OpenQbit.Accounts.Service.WebAPIService.Controllers.API
{
    public class CustomerSystemController : ApiController
    {
        public ApiCustomerSystem Get(int Id)
        {
            ApiCustomerSystem CustomerSystem = new ApiCustomerSystem
            {
                Id = 3,
                Name = "cbc",
                CustomerId = 3,

            };

            return CustomerSystem;
        }

        public List<ApiCustomerSystem> GetList()
        {
            List<ApiCustomerSystem> customersystemlist = new List<ApiCustomerSystem>();

            ApiCustomerSystem customersystem1 = new ApiCustomerSystem
            {
                Id = 1,
                Name = "bbc",
                CustomerId = 1,

            };

            ApiCustomerSystem customersystem2 = new ApiCustomerSystem
            {
                Id = 2,
                Name = "Abc",
                CustomerId = 2,

            };

            customersystemlist.Add(customersystem1);
            customersystemlist.Add(customersystem2);

            return customersystemlist;
        }
    }
}
