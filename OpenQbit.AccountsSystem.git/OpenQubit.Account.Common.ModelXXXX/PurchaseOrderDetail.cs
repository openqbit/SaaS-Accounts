using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Account.Common.Model
{
    class PurchaseOrderDetail
    {
        public int PurOrdId { get; set; }
        public DateTime PurDate { get; set; }
        public double UnitPrice { get; set; }

        public int QuantityOnHand { get; set; }
        public double TotalAmount{ get; set; }

        public int SupplierId{ get; set; }

        public int MyProperty { get; set; }


    }
}
