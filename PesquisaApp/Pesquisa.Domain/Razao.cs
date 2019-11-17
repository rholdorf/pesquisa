using System;
using System.Collections.Generic;
using System.Text;

namespace Pesquisa.Domain
{
    internal class Razao : BaseEntity
    {
        public int Id { get; set; }
        public int IdGrupoRazao { get; set; }
        public string Texto { get; set; }
    }
}
