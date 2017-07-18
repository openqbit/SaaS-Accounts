using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using OpenQbit.Accounts.Service.WebAPIService.Models.API;

namespace OpenQbit.Accounts.Service.WebAPIService.Controllers.API
{
    public class DocumentController : ApiController
    {
        public ApiDocument Get(int Id)
        {
            ApiDocument Document = new ApiDocument
            {
                Id = 1,
                Name = "Abc",
                CustomerId = 1,

            };

            return Document;
        }

        public List<ApiDocument> GetList()
        {
            List<ApiDocument> documentlist = new List<ApiDocument>();

            ApiDocument document1 = new ApiDocument
            {
                Id = 1,
                Name = "Abc",
                CustomerId = 1,

            };

            ApiDocument document2 = new ApiDocument
            {
                Id = 2,
                Name = "Bcd",
                CustomerId = 1,

            };

            documentlist.Add(document2);
            documentlist.Add(document1);

            return documentlist;
        }
    }
}
