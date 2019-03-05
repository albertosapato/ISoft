using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class ProdutosStockArmazemEstados
    {
        public ProdutosStockArmazemEstados()
        {
            ProdutosStockArmazem = new HashSet<ProdutosStockArmazem>();
        }

        public int ProdutosStockArmazemEstadosId { get; set; }
        public string Estado { get; set; }
        public bool Disponibilidade { get; set; }

        public virtual ICollection<ProdutosStockArmazem> ProdutosStockArmazem { get; set; }
    }
}
