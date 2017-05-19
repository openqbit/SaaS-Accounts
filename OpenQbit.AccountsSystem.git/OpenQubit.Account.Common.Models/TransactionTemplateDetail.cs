using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Account.Common.Models
{
    class TransactionTemplateDetail
    {
        public int TempId { get; set; }

        public int AccId { get; set; }

        public double Credit { get; set; }

        public double Debit { get; set; }

        public string Amount { get; set; }


    }
}
