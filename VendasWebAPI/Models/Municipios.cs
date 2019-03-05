using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class Municipios
    {
        public int MunicioId { get; set; }
        public string MunicipioNome { get; set; }
        public string Densidade { get; set; }
        public string Localizacao { get; set; }
        public int ProvinciaId { get; set; }

        public virtual Provincias Provincia { get; set; }
    }
}
