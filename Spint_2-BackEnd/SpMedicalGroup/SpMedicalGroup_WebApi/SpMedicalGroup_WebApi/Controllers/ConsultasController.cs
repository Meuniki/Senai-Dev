using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpMedicalGroup_WebApi.Domains;
using SpMedicalGroup_WebApi.Interfaces;
using SpMedicalGroup_WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {
        /// <summary>
        /// Objeto _consultaRepository que irá receber todos métodos definidos na interface IConsultaRepository
        /// </summary>
        private IConsultaRepository _consultarepository { get; set; }

        /// <summary>
        /// Instancia o objeto _consultaRepository para que haja a rferência aos métodos no repositório
        /// </summary>
        public ConsultasController()
        {
            _consultarepository = new ConsultaRepository();
        }

        /// <summary>
        /// Lista todas Consultas
        /// </summary>
        /// <returns>Uma lista de Consultas e um status code 200 - Ok</returns>
        /// dominio/api/consultas
        /// o usuário precisa estar logado para listar todos os gêneros
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {

            try
            {
                return Ok(_consultarepository.ListarTodos());
            }
            catch (Exception ex )
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Busca uma consulta através do sei ID
        /// </summary>
        /// <param name="id">ID da consulta a ser buscada</param>
        /// <returns>Uma consulta encontrada e um status code 200 - Ok</returns>
        /// somente o usuário administradores e medicos pode buscar pelo id
        [Authorize(Roles = "2, 3")]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_consultarepository.BuscarPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Lista todos as presenças de um determinado usuário
        /// </summary>
        /// <returns>Uma lista de presenças e um status code 200 - Ok</returns>
        /// dominio/api/presencas/minhas
        // Define que somente o usuário comum pode acessar o método
        [Authorize(Roles = "1")]
        [HttpGet("minhas")]
        public IActionResult GetMy()
        {
            try
            {
                // Cria uma variável idUsuario que recebe o valor do ID do usuário que está logado
                int idUsuario = Convert.ToInt32(HttpContext.User.Claims.First(c => c.Type == JwtRegisteredClaimNames.Jti).Value);

                // Retora a resposta da requisição 200 - OK fazendo a chamada para o método e trazendo a lista
                return Ok(_consultarepository.ListarMinhas(idUsuario));
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

        /// <summary>
        /// Cadastra uma nova consulta
        /// </summary>
        /// <param name="novaConsulta">Objeto novaConsulta que será cadastrada</param>
        /// <returns>Um status 201 - Created</returns>
        [Authorize(Roles = "3")]
        [HttpPost]
        public IActionResult Post(Consulta novaConsulta)
        {
            _consultarepository.Cadastrar(novaConsulta);

            return StatusCode(201);
        }

        /// <summary>
        /// Atualiza uma consulta existente
        /// </summary>
        /// <param name="id">ID da consulta que será atualizada</param>
        /// <param name="consultaAtualizada">Objeto da consultaAtualizada com as novas informações </param>
        /// <returns> Um status code 204 - No Content</returns>
        /// 
        [Authorize (Roles = "2")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Consulta consultaAtualizada)
        {
            _consultarepository.Atualizar(id, consultaAtualizada);

            return StatusCode(204);
        }

        /// <summary>
        /// Deleta uma consulta existente
        /// </summary>
        /// <param name="id">ID da consulta que será deletada</param>
        /// <returns>Um status code 204 - No Content</returns>
        /// 
        [Authorize (Roles = "2,3")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _consultarepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
