using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class SubCategoria
    {
        public SubCategoria()
        {
            Produto = new HashSet<Produto>();
        }

        public int SubCategoriaId { get; set; }
        public string SubCategoriaNome { get; set; }
        public string Cometarios { get; set; }
        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Produto> Produto { get; set; }
    }
}
