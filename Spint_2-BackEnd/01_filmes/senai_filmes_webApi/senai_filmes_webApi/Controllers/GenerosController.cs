using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_filmes_webApi.Domains;
using senai_filmes_webApi.Interfaces;
using senai_filmes_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Controller responsaveis pelos endpoints (Urls) refenetes aos gêneros
/// </summary>
namespace senai_filmes_webApi.Controllers
{
    // Define o tipo de resposta da API será no formato JSON
    [Produces("application/json")]
    // Define  que a rota da requisisão será no formato dominio/api/nomeController
    // ex http://localhost:5000/api/generos
    [Route("api/[controller]")]

    // Define que é um controlador de API
    [ApiController]
    public class GenerosController : ControllerBase
    {
        /// <summary>
        /// Objeto _generoRepository que irá receber todos os métodos definidos na interface IGenerosRepository
        /// </summary>
        private IGeneroRepository _generoRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _generoRepository para que haja a referência aos métodos no repositório
        /// </summary>
        public GenerosController()
        {
            _generoRepository = new GeneroRepository();
        }

        /// <summary>
        /// Lista todos gêneros
        /// </summary>
        /// <returns>Uma lista  de gêneros e um status code</returns>
        /// http://localhost:5000/api/generos
        [HttpGet]
        public IActionResult Get()
        {
            // Cria uma lista nomeada listaGeneros para receberos dados
            List<GeneroDomain> listaGeneros = _generoRepository.ListarTodos();

            // Retorna o status code 200 (ok) com a lista de gêneros no formato JSON
            return Ok(listaGeneros);
        }

        /// <summary>
        /// Cadastra um novo genero
        /// </summary>
        /// <param name="novoGenero">Objeto novoGenero recebido na requisição</param>
        /// <returns>Um status code 201 - Created</returns>
        /// http://localhost:5000/api/generos
        [HttpPost]
        public IActionResult Post(GeneroDomain novoGenero)
        {
            // Faz a chamada para o metodo .Cadastrar()
            _generoRepository.Cadastrar(novoGenero);

            // Retorna o status code 201 - Created
            return StatusCode(201);
        }
    }
}
