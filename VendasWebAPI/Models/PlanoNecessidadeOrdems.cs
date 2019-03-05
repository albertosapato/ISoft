using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class PlanoNecessidadeOrdems
    {
        public int PlanoNecessidadeOrdemOrdemId { get; set; }
        public string Referencia { get; set; }
        public int Quantidade { get; set; }
        public int PontosVendaId { get; set; }
        public int ProdutoId { get; set; }

        public virtual PontosVenda PontosVenda { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual PlanoNecessidades ReferenciaNavigation { get; set; }
    }
}
