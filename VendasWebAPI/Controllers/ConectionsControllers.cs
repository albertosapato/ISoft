namespace VendasWebAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using VendasWebAPI.Models;

    [Route("api/[controller]")]
    public class ConectionsController
    {
        // GET api/Conections
        [HttpGet]
        public Usuarios Get()
        {
            using (var resultData = new iSoftVendasContext())
            {
                return resultData.Usuarios.FirstOrDefault();               
            }
        }
    }
}
