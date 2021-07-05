using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpMedicalGroup_WebApi.Domains;
using SpMedicalGroup_WebApi.Interfaces;
using SpMedicalGroup_WebApi.Repositories;
using System;
using System.Collections.Generic;
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
        /// <returns>Uma lista de Consultas e um status code</returns>
        /// dominio/api/consultas
        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_consultarepository.ListarTodos());
        }

        /// <summary>
        /// Busca uma consulta através do sei ID
        /// </summary>
        /// <param name="id">ID da consulta a ser buscada</param>
        /// <returns>Uma consulta encontrada e um status code 200 - Ok</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_consultarepository.BuscarPorId(id));
        }

        /// <summary>
        /// Cadastra uma nova consulta
        /// </summary>
        /// <param name="novaConsulta">Objeto novaConsulta que será cadastrada</param>
        /// <returns>Um status 201 - Created</returns>
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
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _consultarepository.Deletar(id);

            return StatusCode(204);
        }
}
