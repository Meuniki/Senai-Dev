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
    public class CategoriasController : ControllerBase
    {
        /// <summary>
        /// Objeto _categoriaRepository que irá receber todos métodos definidos na interface ICategoriaReposioty
        /// </summary>
        private ICategoriaRepository _categoriaRepository { get; set; }

        /// <summary>
        /// Instacia o objeto _categoriaRepository para que haja a referência aos métodos no repositório
        /// </summary>
        public CategoriasController()
        {
            _categoriaRepository = new CategoriaRepository();
        }

        /// <summary>
        /// Lista todas as categoria
        /// </summary>
        /// <returns>Uma lista de categoria e um status code 200 - Ok</returns>
        /// 
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {

            try
            {
                return Ok(_categoriaRepository.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Cadastra uma nova categoria
        /// </summary>
        /// <param name="novaCategoria">Objeto novoCategoria que será cadastrada</param>
        /// <returns>Um status 201 - Created</returns>
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Categoria novaCategoria)
        {
            _categoriaRepository.Cadastrar(novaCategoria);

            return StatusCode(201);
        }

        /// <summary>
        /// Deleta uma categoria existente
        /// </summary>
        /// <param name="id">ID da categoria que será deletada</param>
        /// <returns>Um status code 204 - No Content</returns>
        /// 
        //[Authorize(Roles = "2,3")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _categoriaRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
