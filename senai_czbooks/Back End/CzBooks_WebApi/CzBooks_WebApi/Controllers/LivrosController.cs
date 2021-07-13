using CzBooks_WebApi.Domains;
using CzBooks_WebApi.Interfaces;
using CzBooks_WebApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace CzBooks_WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        /// <summary>
        /// Objeto _livroRepository que irá receber todos métodos definidos na interface ILivroReposioty
        /// </summary>
        private ILivroRepository _livroRepository { get; set; }

        /// <summary>
        /// Instacia o objeto _livroRepository para que haja a referência aos métodos no repositório
        /// </summary>
        public LivrosController()
        {
            _livroRepository = new LivroRepository();
        }

        /// <summary>
        /// Lista todos os livros
        /// </summary>
        /// <returns>Uma lista de Livros e um status code 200 - Ok</returns>
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {

            try
            {
                return Ok(_livroRepository.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Cadastra um novo livros
        /// </summary>
        /// <param name="novoLivro">Objeto novoLivro que será cadastrada</param>
        /// <returns>Um status 201 - Created</returns>
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Livro novoLivro)
        {
            _livroRepository.Cadastrar(novoLivro);

            return StatusCode(201);
        }

        /// <summary>
        /// Deleta um livro existente
        /// </summary>
        /// <param name="id">ID do livro que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        /// 
        [Authorize(Roles = "1")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _livroRepository.Deletar(id);

            return StatusCode(204);
        }

        /// <summary>
        /// Lista todos as presenças de um determinado usuário
        /// </summary>
        /// <returns>Uma lista de presenças e um status code 200 - Ok</returns>
        /// dominio/api/presencas/minhas
        // Define que somente o usuário comum pode acessar o método
        [Authorize(Roles = "3")]
        [HttpGet("meus")]
        public IActionResult GetMy()
        {
            try
            {
                // Cria uma variável idUsuario que recebe o valor do ID do usuário que está logado
                int idUsuario = Convert.ToInt32(HttpContext.User.Claims.First(c => c.Type == JwtRegisteredClaimNames.Jti).Value);

                // Retora a resposta da requisição 200 - OK fazendo a chamada para o método e trazendo a lista
                return Ok(_livroRepository.ListarMeus(idUsuario));
            }
            catch (Exception error)
            {
                // Retorna a resposta da requisição 400 - Bad Request e o erro ocorrido
                return BadRequest(new
                {
                    mensagem = "Não é possível mostrar as presenças se o usuário não estiver logado!",
                    error
                });
            }
        }
    }
}
