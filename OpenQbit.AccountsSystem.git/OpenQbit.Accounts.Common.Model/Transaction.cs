using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Account.Common.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public DateTime TransactionTime { get; set; }

        public string Description { get; set; }
        //public int TempId { get; set; }
        
        public string ReferenceTag { get; set; }

        public int TransactionTemplateId { get; set; }

        public virtual TransactionTemplate TransactionTemplate { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetail { get; set; }

    }
}
