using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class Caixa
    {
        public int CaixaId { get; set; }
        public DateTime Data { get; set; }
        public DateTime? DataCriacao { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoFinal { get; set; }
        public bool Estado { get; set; }
        public int DepartamentoId { get; set; }
        public int UsuariosId { get; set; }

        public virtual Departamentos Departamento { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
