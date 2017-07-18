using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OpenQbit.Accounts.Service.WebAPIService.Controllers.API
{
    public class CustomerController :  ApiController
    {
        public ApiCustomer Get(int Id)
        {
            ApiCustomer Account = new ApiCustomer
            {
                Id = 1,
                SystemId = 1,
                Name = "Hbc",

            };

            return Account;
        }

        public List<ApiCustomer> GetList()
        {
            List<ApiCustomer> customerList = new List<ApiCustomer>();

            ApiCustomer customer1 = new ApiCustomer
            {
                Id = 1,
                SystemId = 1,
                Name = "Abc",

            };

            ApiCustomer customer2= new ApiCustomer
            {
                Id = 2,
                SystemId =1,
                Name = "Def",

            };

            customerList.Add(customer1);
            customerList.Add(customer2);

            return customerList;
        }
    }
}
