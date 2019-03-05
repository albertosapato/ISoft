using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class Provincias
    {
        public Provincias()
        {
            Departamentos = new HashSet<Departamentos>();
            Fornecedor = new HashSet<Fornecedor>();
            Municipios = new HashSet<Municipios>();
        }

        public int ProvinciaId { get; set; }
        public string ProvinciaNome { get; set; }
        public string Densidade { get; set; }
        public string Clima { get; set; }
        public string Localizacao { get; set; }
        public string Riquesas { get; set; }

        public virtual ICollection<Departamentos> Departamentos { get; set; }
        public virtual ICollection<Fornecedor> Fornecedor { get; set; }
        public virtual ICollection<Municipios> Municipios { get; set; }
    }
}
