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

        public int DocumentTypeId { get; set; }

        
        public string Description { get; set; }

        public virtual DocumentType DocumentType { get; set; }
        


    }
}
