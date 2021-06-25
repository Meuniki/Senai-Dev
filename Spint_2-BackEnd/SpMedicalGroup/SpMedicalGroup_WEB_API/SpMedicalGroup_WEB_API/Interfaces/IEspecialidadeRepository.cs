using SpMedicalGroup_WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Interfaces
{
    /// <summary>
    /// Interface Responsavel pelo repositorio EspecialidadeRepository
    /// </summary>
    public interface IEspecialidadeRepository
    {
        /// <summary>
        /// Retorna Todas especialidades
        /// </summary>
        /// <returns>Uma lista de especialidades</returns>
        List<EspecialidadeDomain> ListarTodos();

        /// <summary>
        /// Busca uma especialidade através do seu id
        /// </summary>
        /// <param name="id">id da especialidade a ser buscado</param>
        /// <returns>Um objeto do tipo EspecialidadeDomain que foi buscado</returns>
        List<EspecialidadeDomain> BuscarPorIs(int id);

        /// <summary>
        /// Cadastra um novo objeto EspecialidadeDomain
        /// </summary>
        /// <param name="novoEspecialidade">Objeto EspecialidadeDomain que será cadastrado</param>
        void Cadastrar(EspecialidadeDomain novoEspecialidade);

        /// <summary>
        /// Atualiza um usuário existente passando id pelo corpo da requisição
        /// </summary>
        /// <param name="especialidade">Objeto especialidade a ser atualizado</param>
        void Atualizar(EspecialidadeDomain especialidade);

        /// <summary>
        /// Deleta uma especialidade
        /// </summary>
        /// <param name="id">Id da especialidade a ser deletado</param>
        void Deletar(int id);
    }
}
