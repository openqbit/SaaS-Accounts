using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Account.Common.Model
{
    class Invoice
    {
        //public virtual ICollection<Customer>CusID{ get; set; } this must be a foreign key
        public int InvoiceId{ get; set; }
        public int Contact{ get; set; }
        public string SelpRep{ get; set; }
        public DateTime InvoiceDate { get; set; }


    }
}
