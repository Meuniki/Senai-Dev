using Microsoft.AspNetCore.Http;
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

            List<ClinicaDomain> listaClinicas = _clinicarepository.ListarTodos();

            return Ok(listaClinicas);
        }
    }
}
