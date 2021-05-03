using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai_Peoples_WebApi_Manha.Domains;
using Senai_Peoples_WebApi_Manha.Interfaces;
using Senai_Peoples_WebApi_Manha.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Peoples_WebApi_Manha.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase{

        private IFuncionarioRepository _funcionarioRepository { get; set; }

        public FuncionariosController(){

            _funcionarioRepository = new FuncionarioRepository();
        }

        /// <summary>
        /// Lista todos funcionários
        /// </summary>
        /// <returns>Uma lista de funcionários e um status code</returns>
        /// http://localhost:5000/api/funcionarios
        [HttpGet]
        public IActionResult Get(){

            List<FuncionarioDomain> funcionarios = _funcionarioRepository.ListarTodos();

            return Ok(funcionarios);
        }

        /// <summary>
        /// Busca funcionário atravez do seu id
        /// </summary>
        /// <param name="id"> id do funcionário que será buscado</param>
        /// <returns>O funcionário buscado ou NotFound caso nenhum funcionário seja encontrado</returns>
        /// http://localhost:5000/api/funcionarios/1
        [HttpGet("{id}")]
        public IActionResult Get(int id){
            
            FuncionarioDomain funcionarioBuscado = _funcionarioRepository.BuscarPorId(id);

            if (funcionarioBuscado == null){
                return NotFound("funcionário não encontrado");
            }
            return Ok(funcionarioBuscado);
        }

        /// <summary>
        /// Cadastra um novo funcionário
        /// </summary>
        /// <param name="novoFuncionario">Objeto novoFuncionario recebido na requisição</param>
        /// <returns>Um status code 201 - Created</returns>
        /// http://localhost:5000/api/funcionarios
        [HttpPost]
        public IActionResult Post(FuncionarioDomain novoFuncionario){
            
            _funcionarioRepository.Cadastrar(novoFuncionario);

            return StatusCode(201);
        }

        /// <summary>
        /// Atualiza um funcionário existente passando seu id pela URL da requisição
        /// </summary>
        /// <param name="id">id do funcionário que será atualizado </param>
        /// <param name="funcionarioAtualizado">Objeto com as novas informações</param>
        /// <returns>Um status code</returns>
        /// http://localhost:5000/api/funcionarios/1
        [HttpPut("{id}")]
        public IActionResult PutUrl(int id, FuncionarioDomain funcionarioAtualizado){
            
            FuncionarioDomain funcionarioBuscado = _funcionarioRepository.BuscarPorId(id);

            if (funcionarioBuscado == null){
                return NotFound(
                    new{
                        mensagem = "Funcionário não encontrado",
                        erro = true
                    });
            }

            try{
                _funcionarioRepository.Atualizar(id, funcionarioAtualizado);
                return NoContent();
            }
            catch (Exception erro){
                return BadRequest(erro);
            }
        }

        /// <summary>
        /// Deleta um funcionário existente
        /// </summary>
        /// <param name="id">id do funcionário que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        /// http://localhost:5000/api/funcionarios/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            
            _funcionarioRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
