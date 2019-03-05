using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class ProdutosSugestao
    {
        public int ProdutosSugestaoId { get; set; }
        public DateTime Data { get; set; }
        public string Produtos { get; set; }
        public string Cometarios { get; set; }
        public int DepartamentoId { get; set; }
        public int UsuariosId { get; set; }

        public virtual Departamentos Departamento { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
