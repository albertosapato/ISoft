using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class CaixaAnual
    {
        public CaixaAnual()
        {
            CaixaResumo = new HashSet<CaixaResumo>();
        }

        public int CaixaAnualId { get; set; }
        public DateTime Date { get; set; }
        public DateTime DataModificacao { get; set; }
        public decimal Saldo { get; set; }
        public bool Estado { get; set; }
        public int Ano { get; set; }
        public int DepartamentoId { get; set; }

        public virtual Departamentos Departamento { get; set; }
        public virtual ICollection<CaixaResumo> CaixaResumo { get; set; }
    }
}
