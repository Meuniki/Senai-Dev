using SpMedicalGroup_WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Interfaces
{
    /// <summary>
    /// Interface responsavel pelo repositorio PacienteRepository
    /// </summary>
    public interface IPacienteRepository
    {
        /// <summary>
        /// Retorna Todos pacientes
        /// </summary>
        /// <returns>Uma lista de pacientes</returns>
        List<PacienteDomain> ListarTodos();

        /// <summary>
        /// Busca um paciente através do seu id
        /// </summary>
        /// <param name="id">id do paciente a ser buscado</param>
        /// <returns>Um objeto do tiopo PacienteDomain que foi buscado</returns>
        List<PacienteDomain> BuscarPorIs(int id);

        /// <summary>
        /// Cadastra um novo objeto PacienteDomain
        /// </summary>
        /// <param name="novoPaciente">Objeto PacienteDomain que será cadastrado</param>
        void Cadastrar(PacienteDomain novoPaciente);

        /// <summary>
        /// Atualiza um paciente existente passando id pelo corpo da requisição
        /// </summary>
        /// <param name="paciente">Objeto paciente a ser atualizado</param>
        void Atualizar(PacienteDomain paciente);

        /// <summary>
        /// Deleta um paciente
        /// </summary>
        /// <param name="id">Id do paciente a ser deletado</param>
        void Deletar(int id);
    }
}
