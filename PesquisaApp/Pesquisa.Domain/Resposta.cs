using System;
using System.Collections.Generic;
using System.Text;

namespace Pesquisa.Domain
{
    public class Resposta : BaseEntity
    {
         public Resposta()
        {
            Razoes = new List<Razao>();
        }

        public string Id { get; set; }
        public int IdPesquisa { get; set; }
        public int Nota { get; set; }
        public string ExtraInfo { get; set; }
        public List<Razao> Razoes { get; set; }
        public Pesquisa Pesquisa { get; set; }
    }
}
