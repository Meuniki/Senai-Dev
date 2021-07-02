using SpMedicalGroup_WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Interfaces
{
    /// <summary>
    /// Interface responsavel pelo repositorios ClinicaRepository
    /// </summary>
    public interface IClinicaRepository
    {
        /// <summary>
        /// Retorna Todas clinicas
        /// </summary>
        /// <returns>Uma lista de clinicas</returns>
        List<Clinica> ListarTodos();

        /// <summary>
        /// Busca uma clinica através do seu id
        /// </summary>
        /// <param name="id">id da clinica a ser buscado</param>
        /// <returns>Um objeto do tipo Clinica que foi buscado</returns>
        Clinica BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo objeto Clinica
        /// </summary>
        /// <param name="novaClinica">Objeto Clinica que será cadastrado</param>
        void Cadastrar(Clinica novaClinica);

        /// <summary>
        /// Atualiza um usuário existente passando id pelo corpo da requisição
        /// </summary>
        /// <param name="id"> id da clinica a ser atualizado</param>
        /// <param name="clinicaAtualizada"> Objeto clinica a ser atualizado</param>
        void Atualizar(int id, Clinica clinicaAtualizada);

        /// <summary>
        /// Deleta uma clinica
        /// </summary>
        /// <param name="id">Id da clinica a ser deletado</param>
        void Deletar(int id);
    }
}
