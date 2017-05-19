using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Account.Common.Models
{
    class AccountsModel
    {
        public int AccId { get; set; }
        public int ParentAccId { get; set; }
        public string AccName { get; set; }
    }
}
