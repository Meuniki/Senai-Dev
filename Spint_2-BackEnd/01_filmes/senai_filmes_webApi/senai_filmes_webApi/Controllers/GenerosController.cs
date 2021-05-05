using Microsoft.AspNetCore.Authorization;
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
/// Controller responsaveis pelos endpoints (URLs) refenetes aos gêneros
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
        /// Objeto _generoRepository que ira receber todos os métodos definidos na interface IGenerosRepository
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
        /// <returns>Uma lista de gêneros e um status code</returns>
        /// http://localhost:5000/api/generos
        /// o usuário precisa estar logado para listar todos os gêneros
        [Authorize] // verifica se o usuário está logado
        [HttpGet]
        public IActionResult Get()
        {
            // Cria uma lista nomeada listaGeneros para receberos dados
            List<GeneroDomain> listaGeneros = _generoRepository.ListarTodos();

            // Retorna o status code 200 (ok) com a lista de gêneros no formato JSON
            return Ok(listaGeneros);
        }

        /// <summary>
        /// Busca um gênero através do seu id
        /// </summary>
        /// <param name="id"> id do gênero que será buscado</param>
        /// <returns>Um gênero buscado ou NotFound caso nenhum gênero seja encontrado</returns>
        /// http://localhost:5000/api/generos/1
        /// somente o usuário administrador pode buscar um gênero pelo id
        [Authorize(Roles = "administrador")]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Cria um objeto generoBuscado que irá receber o gênero buscado no banco de dados 
            GeneroDomain generoBuscado = _generoRepository.BuscarPorId(id);

            // Verifica se nenhum gênero foi encontrado
            if (generoBuscado == null)
            {
                // Caso não seja encontrado, retorna um statuscode 404 - Not Found com a mensagem personalizada
                return NotFound("Nenhum gênero foi encontrado");
            }

            // Caso seja encontrado, retorna o gênero buscado com um status code 200 - Ok
            return Ok(generoBuscado);
            
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

        /// <summary>
        /// Atualiza um gênero existente passando o seu id pela URL da requisição
        /// </summary>
        /// <param name="id">id do gênero que será atualizado</param>
        /// <param name="generoAtualizado">Objeto generoAtualizado com as novas informações</param>
        /// <returns>Um status code</returns>
        /// http://localhost:5000/api/generos/3
        [HttpPut("{id}")]
        public IActionResult PutUrl(int id, GeneroDomain generoAtualizado)
        {
            // Cria um objeto generoBuscado que irá receber o gênero buscado no banco de dados
            GeneroDomain generoBuscado = _generoRepository.BuscarPorId(id);

            // Caso não seja encontrado, retorna NotFound com uma mensagem personalizada
            // e um bool para apresentar que ouve erro
            if (generoBuscado == null)
            {
                return NotFound(new
                {
                    mensagem = "Gênero não encontrado",
                    erro = true
                });
            }

            // Tenta atualizar o registro
            try
            {
                // Faz a chamada para o método .AtualizarIdUrl()
                _generoRepository.AtualizarIdUrl(id, generoAtualizado);

                // Retorna um status code 204 - No Content
                return NoContent();
            }
            //CAso ocorra algum erro
            catch (Exception erro)
            {
                // Retorna um status 400 - BadRequest e o código de erro
                return BadRequest(erro);
            }
        }

        /// <summary>
        /// Atualiza um gênero existente passando o seu id pelo corpo da requisição
        /// </summary>
        /// <param name="generoAtualizado">Objeto generoAtualizado com as nocas informações</param>
        /// <returns>Um status code</returns>
        [HttpPut]
        public IActionResult PutIdBody(GeneroDomain generoAtualizado)
        {
            // Cria um objeto generoBuscado que irá receber o gênero buscado no banco de dados
            GeneroDomain generoBuscado = _generoRepository.BuscarPorId(generoAtualizado.idGenero);

            // Verifica se algum gênero foi encontrado
            if (generoBuscado != null)
            {
                // Se sim, tenta atualizaro registro
                try
                {
                    // Faz a chamada para o método . AtualiarIdCorpo()
                    _generoRepository.AtualizarIdCorpo(generoAtualizado);

                    // Retorna um status code 204 - No Content
                    return NoContent();
                }
                // Caso ocorra algum erro
                catch (Exception erro)
                {
                    // Retorna um BadRequest e o código de erro
                    return BadRequest(erro);
                }
            }
            return NotFound(
                new{ 
                erro = true,
                mensagem = "Gênero não encontrado"
                }
            );
        }
        /// <summary>
        /// Deleta um gênero existente
        /// </summary>
        /// <param name="id">id gênero que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        /// http://localhost:5000/api/generos/deletar/4
        [HttpDelete("{id}")]
        public IActionResult Delete (int id)
        {
            // Faz a chamada para o metodo deletar
            _generoRepository.Deletar(id);

            //Retorna 
            return StatusCode(204);
        }
    }
}
