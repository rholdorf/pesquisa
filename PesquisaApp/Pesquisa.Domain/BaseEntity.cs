using System;
using System.Collections.Generic;
using System.Text;

namespace Pesquisa.Domain
{
    internal class BaseEntity
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateDeleted { get; set; }
        public bool IsDeleted { get; set; }
    }
}
