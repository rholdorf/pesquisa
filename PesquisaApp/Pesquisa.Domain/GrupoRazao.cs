using System;
using System.Collections.Generic;
using System.Text;

namespace Pesquisa.Domain
{
    internal class GrupoRazao : BaseEntity
    {
        public int Id { get; set; }
        public int Texto { get; set; }
        public int Nota { get; set; }
    }
}
