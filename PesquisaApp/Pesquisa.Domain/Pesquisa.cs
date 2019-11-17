using System;
using System.Collections.Generic;
using System.Text;

namespace Pesquisa.Domain
{
    internal class Pesquisa : BaseEntity
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Id { get; set; }
        public string Texto { get; set; }
    }
}
