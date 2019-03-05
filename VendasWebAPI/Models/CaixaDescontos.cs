using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class CaixaDescontos
    {
        public int CaixaDescontosId { get; set; }
        public decimal ValorAumento { get; set; }
        public decimal ValorDiminui { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Horas { get; set; }
        public string Descricao { get; set; }
        public int UsuariosId { get; set; }
        public int DepartamentoId { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
