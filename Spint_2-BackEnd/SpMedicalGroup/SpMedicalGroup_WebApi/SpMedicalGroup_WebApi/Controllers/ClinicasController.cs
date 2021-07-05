﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpMedicalGroup_WebApi.Domains;
using SpMedicalGroup_WebApi.Interfaces;
using SpMedicalGroup_WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Controller responsável pelos endpoints (URLs) referentes as Clinicas
/// </summary>
namespace SpMedicalGroup_WebApi.Controllers{

    // Define que o formato da api será no formato json
    [Produces("application/json")]
    // http://localhost:5000/api/clinicas
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicasController : ControllerBase {

        /// <summary>
        /// Objeto _clinicaRepository que irá receber todos métodos definidos na interface IClinicaRepository
        /// </summary>
        private IClinicaRepository _clinicarepository { get; set; }

        /// <summary>
        /// Instancia o objeto _clinicaRepository para que haja a rferência aos métodos no repositório
        /// </summary>
        public ClinicasController() {

            _clinicarepository = new ClinicaRepository();
        }

        /// <summary>
        /// Lista todas Clinicas
        /// </summary>
        /// <returns>Uma lista de Clinicas e um status code</returns>
        /// dominio/api/clinicas
        [HttpGet]
        public IActionResult Get(){

            return Ok(_clinicarepository.ListarTodos());
        }

        /// <summary>
        /// Busca uma clinica através do sei ID
        /// </summary>
        /// <param name="id">ID da clinica a ser buscada</param>
        /// <returns>Uma clinica encontrada e um status code 200 - Ok</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_clinicarepository.BuscarPorId(id));
        }

        /// <summary>
        /// Cadastra uma nova clinica
        /// </summary>
        /// <param name="novaClinica">Objeto novaClinica que será cadastrada</param>
        /// <returns>Um status 201 - Created</returns>
        [HttpPost]
        public IActionResult Post(Clinica novaClinica)
        {
            _clinicarepository.Cadastrar(novaClinica);

            return StatusCode(201);
        }

        /// <summary>
        /// Atualiza uma clinica existente
        /// </summary>
        /// <param name="id">ID da clinica que será atualizada</param>
        /// <param name="clinicaAtualizada">Objeto da clinicaAtualizada com as novas informações </param>
        /// <returns> Um status code 204 - No Content</returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, Clinica clinicaAtualizada)
        {
            _clinicarepository.Atualizar(id, clinicaAtualizada);

            return StatusCode(204);
        }

        /// <summary>
        /// Deleta uma clinica existente
        /// </summary>
        /// <param name="id">ID da clinica que será deletada</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _clinicarepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
