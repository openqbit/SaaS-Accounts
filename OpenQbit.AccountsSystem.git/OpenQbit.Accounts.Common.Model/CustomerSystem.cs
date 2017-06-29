using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Account.Common.Models
{
    public class CustomerSystem
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Document> Document { get; set; }
        public virtual ICollection<Account> Account { get; set; }
    }
}
