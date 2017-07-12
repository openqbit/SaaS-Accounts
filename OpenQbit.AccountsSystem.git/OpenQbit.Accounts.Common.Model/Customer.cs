using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Accounts.Common.Model;
using OpenQubit.Account.Common.Models;

namespace OpenQubit.Account.Common.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DocumentType> DocumentType { get; set; }
        public virtual ICollection<CustomerSystem> CustomerSystem { get; set; }
    }
}
