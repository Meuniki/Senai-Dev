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
/// Controller responsaveis pelos endpoints referentes aos filmes
/// </summary>
namespace senai_filmes_webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        /// <summary>
        /// Objeto _filmeRepositry que ira receber todosos métodos defiidosna interface IFilmesRepository
        /// </summary>
        private IFilmeRepository _filmeRepository { get; set; }

        /// <summary>
        /// Instacia o objeto _fimeRepository para que haja uma referência aos métodos no repositrio
        /// </summary>
        public FilmesController()
        {
            _filmeRepository = new FilmeRepository();
        }

        /// <summary>
        /// Lista todos filmes
        /// </summary>
        /// <returns>Uma lista de filmes e um status code</returns>
        /// http://localhost:5000/api/filmes
        [HttpGet]
        public IActionResult Get()
        {
            List<FilmeDomain> listaFilmes = _filmeRepository.ListarTodos();

            return Ok(listaFilmes);
        }

        /// <summary>
        /// Cadstra um novo filme
        /// </summary>
        /// <param name="novoFilme">Objeto novoFilme recebido na requisição</param>
        /// <returns>Um status code 201 - Created</returns>
        /// http://localhost:5000/api/filmes
        [HttpPost]
        public IActionResult Post(FilmeDomain novoFilme)
        {
            _filmeRepository.Cadastrar(novoFilme);

            return StatusCode(201);
        }

    }
}
