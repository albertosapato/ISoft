using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebAPI.Models;

namespace VendasWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class UsuariosPermissaoController
    {
        // GET api/Permissoes
        [HttpGet]
        public IEnumerable<Permissoes> Get()
        {
            using (var resultData = new iSoftVendasContext())
            {
                return resultData.Permissoes.ToList();
            }
        }

        [HttpGet("{id}")]
        public Permissoes Get(int Id)
        {
            using (var resultData = new iSoftVendasContext())
            {
                return resultData.Permissoes.Where(x => x.GrupoId == Id)
                                            .FirstOrDefault();
            }
        }
        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Permissoes value)
        {
            using (var db = new iSoftVendasContext())
            {
                db.Permissoes.Add(value);
                db.SaveChanges();
                return new ObjectResult("successfully!");
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]Permissoes value)
        {
            using (var db = new iSoftVendasContext())
            {
                db.Entry(value).State = EntityState.Modified;
                db.SaveChanges();
                return new ObjectResult("modified successfully!");
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            using (var db = new iSoftVendasContext())
            {
                db.Permissoes.Remove(db.Permissoes.Find(id));
                db.SaveChanges();
                return new ObjectResult("deleted successfully!");
            }
        }
    }
}
