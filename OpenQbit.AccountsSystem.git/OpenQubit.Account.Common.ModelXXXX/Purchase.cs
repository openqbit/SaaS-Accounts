using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Account.Common.Model
{
    class Purchase
    {
        public int PurchaseId { get; set; }
        public DateTime date { get; set; }
        
        public double tax { get; set; }
        public double extraExpences { get; set; }
        public double discount { get; set; }
        public int quantity { get; set; }

        public virtual ICollection<PurchaseOrderDetail> PurOrdId { get; set; }


    }
}
