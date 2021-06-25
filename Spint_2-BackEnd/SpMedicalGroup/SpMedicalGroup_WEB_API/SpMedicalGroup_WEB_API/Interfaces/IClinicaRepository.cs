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
        List<ClinicaDomain> ListarTodos();

        /// <summary>
        /// Busca uma clinica através do seu id
        /// </summary>
        /// <param name="id">id da clinica a ser buscado</param>
        /// <returns>Um objeto do tipo ClinicaDomain que foi buscado</returns>
        List<ClinicaDomain> BuscarPorIs(int id);

        /// <summary>
        /// Cadastra um novo objeto ClinicaDomain
        /// </summary>
        /// <param name="novoClinica">Objeto ClinicaDomain que será cadastrado</param>
        void Cadastrar(ClinicaDomain novoClinica);

        /// <summary>
        /// Atualiza um usuário existente passando id pelo corpo da requisição
        /// </summary>
        /// <param name="clinica">Objeto clinica a ser atualizado</param>
        void Atualizar(ClinicaDomain clinica);

        /// <summary>
        /// Deleta uma clinica
        /// </summary>
        /// <param name="id">Id da clinica a ser deletado</param>
        void Deletar(int id);
    }
}
