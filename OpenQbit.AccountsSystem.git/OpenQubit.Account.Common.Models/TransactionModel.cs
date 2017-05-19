using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibOpenQubit.Account.Common.Modelsrary1
{
    class TransactionModel
    {
        public int TransactionId { get; set; }

        public int DocId { get; set; }

        //public int TempId { get; set; }
        public virtual ICollection<TransactionTemplate> TempId { get; set; }
    }
}
