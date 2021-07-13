using CzBooks_WebApi.Domains;
using CzBooks_WebApi.Interfaces;
using CzBooks_WebApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CzBooks_WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuariosController()
        {

            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Lista todos os usuário
        /// </summary>
        /// <returns>Uma lista de usuário e um status code 200 - Ok</returns>
        /// 
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {

            try
            {
                return Ok(_usuarioRepository.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <param name="novoUsuario">Objeto novoUsuario que será cadastrada</param>
        /// <returns>Um status 201 - Created</returns>
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Usuario novoUsuario)
        {
            _usuarioRepository.Cadastrar(novoUsuario);

            return StatusCode(201);
        }

        /// <summary>
        /// Deleta um usuário existente
        /// </summary>
        /// <param name="id">ID do usuário que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        /// 
        //[Authorize(Roles = "2,3")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _usuarioRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
