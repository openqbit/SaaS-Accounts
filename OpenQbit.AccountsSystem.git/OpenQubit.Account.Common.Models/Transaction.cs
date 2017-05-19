using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibOpenQubit.Account.Common.Modelsrary1
{
    class Transaction
    {
        public int TransactionId { get; set; }

        public int DocumentId { get; set; }

        //public int TempId { get; set; }
        public virtual ICollection<TransactionTemplate> TransactionTemplateId { get; set; }
    }
}
