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
        List<Paciente> ListarTodos();

        /// <summary>
        /// Busca um paciente através do seu id
        /// </summary>
        /// <param name="id">id do paciente a ser buscado</param>
        /// <returns>Um objeto do tiopo Paciente que foi buscado</returns>
        Paciente BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo objeto Paciente
        /// </summary>
        /// <param name="novoPaciente">Objeto Paciente que será cadastrado</param>
        void Cadastrar(Paciente novoPaciente);

        /// <summary>
        /// Atualiza um usuário existente passando id pelo corpo da requisição
        /// </summary>
        /// <param name="id"> id da paciente a ser atualizado</param>
        /// <param name="pacienteAtualizada"> Objeto paciente a ser atualizado</param>
        void Atualizar(int id, Paciente pacienteAtualizada);

        /// <summary>
        /// Deleta um paciente
        /// </summary>
        /// <param name="id">Id do paciente a ser deletado</param>
        void Deletar(int id);
    }
}
