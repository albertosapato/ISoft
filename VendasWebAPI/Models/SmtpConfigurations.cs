using System;
using System.Collections.Generic;

namespace VendasWebAPI.Models
{
    public partial class SmtpConfigurations
    {
        public int SmtpConfigurationId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public bool Ssl { get; set; }
        public TimeSpan Hora1 { get; set; }
        public TimeSpan Hora2 { get; set; }
        public bool Activo { get; set; }
    }
}
