using System;
using System.Collections.Generic;
using System.Text;

namespace Pesquisa.Domain
{
    public class Pesquisa : BaseEntity
    {
        public int Id { get; set; }
        public int IdSistema { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Texto { get; set; }

        public Sistema Sistema { get; set; }
    }
}
