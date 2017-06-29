﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Account.Common.Models
{
    public class DocumentType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<TransactionTemplate> TransactionTemplate { get; set; }

    }
}
