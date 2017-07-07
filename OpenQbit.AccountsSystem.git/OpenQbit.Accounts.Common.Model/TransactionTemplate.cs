using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace OpenQubit.Account.Common.Models
{
    public class TransactionTemplate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int DocumentId { get; set; }

        public string Description { get; set; }

        public virtual Document Document { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }
        public virtual ICollection<TransactionTemplateDetail> TransactionTemplateDetail { get; set; }



    }
}
