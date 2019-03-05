using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            SubCategoria = new HashSet<SubCategoria>();
        }

        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Cometarios { get; set; }
        public int DepartamentoId { get; set; }

        public virtual Departamentos Departamento { get; set; }
        public virtual ICollection<SubCategoria> SubCategoria { get; set; }
    }
}
