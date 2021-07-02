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
        List<Especialidade> ListarTodos();

        /// <summary>
        /// Busca uma especialidade através do seu id
        /// </summary>
        /// <param name="id">id da especialidade a ser buscado</param>
        /// <returns>Um objeto do tipo Especialidade que foi buscado</returns>
        Especialidade BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo objeto Especialidade
        /// </summary>
        /// <param name="novoEspecialidade">Objeto Especialidade que será cadastrado</param>
        void Cadastrar(Especialidade novoEspecialidade);

        /// <summary>
        /// Atualiza um usuário existente passando id pelo corpo da requisição
        /// </summary>
        /// <param name="especialidade">Objeto especialidade a ser atualizado</param>
        void Atualizar(Especialidade especialidade);

        /// <summary>
        /// Deleta uma especialidade
        /// </summary>
        /// <param name="id">Id da especialidade a ser deletado</param>
        void Deletar(int id);
    }
}
