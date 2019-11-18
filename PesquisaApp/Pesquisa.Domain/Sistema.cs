using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

//namespace Prb.Tardis.Nps.Domain.Entities
namespace Pesquisa.Domain
{
    public class Sistema : BaseEntity
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}