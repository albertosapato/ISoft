using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class Definicoes
    {
        public int DefinicoesId { get; set; }
        public string DefinicoesTitulo { get; set; }
        public string Comercio { get; set; }
        public string Nif { get; set; }
        public string Telemovel { get; set; }
        public string Rua { get; set; }
        public string Email { get; set; }
        public string Ramo { get; set; }
        public string Banco1 { get; set; }
        public string Banco2 { get; set; }
        public string Banco3 { get; set; }
        public string Banco4 { get; set; }
        public string Outros { get; set; }
        public string Photos { get; set; }
        public byte[] PhotosDesk1 { get; set; }
        public byte[] PhotosDesk2 { get; set; }
        public int DepartamentoId { get; set; }

        public virtual Departamentos Departamento { get; set; }
    }
}
