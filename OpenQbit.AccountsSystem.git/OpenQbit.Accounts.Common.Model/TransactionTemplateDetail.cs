using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Account.Common.Models
{
    public class TransactionTemplateDetail
    {
        public int Id { get; set; }

        public int AccountId { get; set; }

        public string CrDb { get; set; }

        //public double Debit { get; set; }

        public string AmountExpression { get; set; }

        public virtual Account Account { get; set; }
    }
}
