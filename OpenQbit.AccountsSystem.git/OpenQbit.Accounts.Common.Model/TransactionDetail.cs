using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace OpenQubit.Account.Common.Models
{
    public class TransactionDetail
    {
        public int Id { get; set; }
        
        public int AccountId { get; set; }

        public int TransactionId { get; set; }

        [DefaultValue(0)]
        public double CrAmount { get; set; }

        [DefaultValue(0)]
        public double DbAmount { get; set; }

        public virtual Account Account { get; set; }
        public virtual Transaction Transaction { get; set; }

    }
}
