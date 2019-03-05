using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class KeysGens
    {
        public int KeysGenId { get; set; }
        public string Key { get; set; }
        public DateTime DataActual { get; set; }
        public DateTime DataFinal { get; set; }
    }
}
