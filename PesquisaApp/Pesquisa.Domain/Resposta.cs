using System;
using System.Collections.Generic;
using System.Text;

namespace Pesquisa.Domain
{
    internal class Resposta : BaseEntity
    {
        public string Id { get; set; }
        public int IdPesquisa { get; set; }
        public int Nota { get; set; }
        public string ExtraInfo { get; set; }
        public List<Razao> Razoes { get; set; }
    }
}
