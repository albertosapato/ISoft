using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using VendasWebAPI.Models;

namespace VendasWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class UsuariosController
    {
        // GET api/Usuarios
        [HttpGet]
        public IEnumerable<Usuarios> Get()
        {
            using (var resultData = new iSoftVendasContext())
            {
                // Buscar Lista Completa
                var result = resultData.Usuarios.Include(x => x.Grupo)
                                                .Include(x => x.Grupo.Permissoes)
                                                .ToList();

                // Buscar e selecionar só valores especificos
                return result.Select(x => new Usuarios()
                {
                    UsuariosId = x.UsuariosId,
                    UsuarioNomeCompleto = x.UsuarioNomeCompleto,
                    Apelido = x.Apelido,
                    Login = x.Login,
                    Senha = x.Senha,
                    Pin = x.Pin,
                    Email = x.Email,
                    Estado = x.Estado,
                    DataNascimento = x.DataNascimento,
                    Perfil = x.Perfil,
                    GrupoId = x.GrupoId,

                    Grupo = new Grupos
                    {
                        GrupoId = x.Grupo.GrupoId,
                        GrupoComentarios = x.Grupo.GrupoComentarios,
                        DepartamentoId = x.Grupo.DepartamentoId,
                        GrupoNome = x.Grupo.GrupoNome,

                        Permissoes = (x.Grupo.Permissoes.Select( k => new Permissoes
                        {
                            AbrirInventarios = k.AbrirInventarios,

                        }))
                        .ToList(),
                    }
                });
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        private void IDisposable()
        {

        }
    }
}
