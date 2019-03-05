using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class ClientesCartaos
    {
        public int ClientesCartaoId { get; set; }
        public string ClinetesNumero { get; set; }
        public DateTime Emissao { get; set; }
        public DateTime Validade { get; set; }
        public string Bi { get; set; }
        public decimal Bonos { get; set; }
        public int ClienteId { get; set; }

        public virtual Clientes Cliente { get; set; }
    }
}
