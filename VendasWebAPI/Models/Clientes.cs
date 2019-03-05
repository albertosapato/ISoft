using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class Clientes
    {
        public Clientes()
        {
            ClientesPagamentosPraso = new HashSet<ClientesPagamentosPraso>();
            Fatura = new HashSet<Fatura>();
            FaturasArmazem = new HashSet<FaturasArmazem>();
            FaturasEncomendas = new HashSet<FaturasEncomendas>();
            FaturasProformas = new HashSet<FaturasProformas>();
            FaturasReservas = new HashSet<FaturasReservas>();
        }

        public int ClienteId { get; set; }
        public string ClienteNome { get; set; }
        public string Nif { get; set; }
        public string Contacto { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public DateTime Aniversario { get; set; }
        public string Notas { get; set; }
        public decimal Desconto { get; set; }
        public int DepartamentoId { get; set; }

        public virtual Departamentos Departamento { get; set; }
        public virtual ClientesCartaos ClientesCartaos { get; set; }
        public virtual ICollection<ClientesPagamentosPraso> ClientesPagamentosPraso { get; set; }
        public virtual ICollection<Fatura> Fatura { get; set; }
        public virtual ICollection<FaturasArmazem> FaturasArmazem { get; set; }
        public virtual ICollection<FaturasEncomendas> FaturasEncomendas { get; set; }
        public virtual ICollection<FaturasProformas> FaturasProformas { get; set; }
        public virtual ICollection<FaturasReservas> FaturasReservas { get; set; }
    }
}
