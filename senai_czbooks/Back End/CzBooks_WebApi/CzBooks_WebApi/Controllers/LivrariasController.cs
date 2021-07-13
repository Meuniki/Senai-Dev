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
    public class LivrariasController : ControllerBase
    {
        /// <summary>
        /// Objeto _livrariaRepository que irá receber todos métodos definidos na interface ILivrariaReposioty
        /// </summary>
        private ILivrariaRepository _livrariaRepository { get; set; }

        /// <summary>
        /// Instacia o objeto _livrariaRepository para que haja a referência aos métodos no repositório
        /// </summary>
        public LivrariasController()
        {
            _livrariaRepository = new LivrariaRepository();
        }

        /// <summary>
        /// Lista todas as livraria
        /// </summary>
        /// <returns>Uma lista de livraria e um status code 200 - Ok</returns>
        /// 
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {

            try
            {
                return Ok(_livrariaRepository.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Cadastra uma nova livraria
        /// </summary>
        /// <param name="novaLivraria">Objeto novoLivraria que será cadastrada</param>
        /// <returns>Um status 201 - Created</returns>
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Livraria novaLivraria)
        {
            _livrariaRepository.Cadastrar(novaLivraria);

            return StatusCode(201);
        }

        /// <summary>
        /// Deleta uma livraria existente
        /// </summary>
        /// <param name="id">ID da livraria que será deletada</param>
        /// <returns>Um status code 204 - No Content</returns>
        /// 
        //[Authorize(Roles = "2,3")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _livrariaRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
