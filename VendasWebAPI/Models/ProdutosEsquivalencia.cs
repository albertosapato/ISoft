using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class ProdutosEsquivalencia
    {
        public int ProdutosEsquivalenciaId { get; set; }
        public int ProdutoId { get; set; }
        public int ProdutoId1 { get; set; }
        public string ProdutoNomeRep { get; set; }

        public virtual Produto ProdutoId1Navigation { get; set; }
    }
}
