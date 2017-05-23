using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Account.Common.Models
{
    public class TransactionDetail
    {
        public int Id { get; set; }

        public int AccountId { get; set; }

        public double Amount { get; set; }
        public string CrDb { get; set; }

        public virtual Account Account { get; set; }

    }
}
