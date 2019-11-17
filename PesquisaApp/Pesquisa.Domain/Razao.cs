using System;
using System.Collections.Generic;
using System.Text;

namespace Pesquisa.Domain
{
    public class Razao : BaseEntity
    {
        public int Id { get; set; }
        public int Nota { get; set; }
        public string Texto { get; set; }
    }
}
