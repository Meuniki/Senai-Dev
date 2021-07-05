using SpMedicalGroup_WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Interfaces
{
    /// <summary>
    /// Interface responsavel pelo repositorio MedicoRepository
    /// </summary>
    public interface IMedicoRepository
    {
        /// <summary>
        /// Retorna Todos medicos
        /// </summary>
        /// <returns>Uma lista de medicos</returns>
        List<Medico> ListarTodos();

        /// <summary>
        /// Busca um medico através do seu id
        /// </summary>
        /// <param name="id">id do medico a ser buscado</param>
        /// <returns>Um objeto do tipo Medico que foi buscado</returns>
        Medico BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo objeto Medico
        /// </summary>
        /// <param name="novoMedico">Objeto Medico que será cadastrado</param>
        void Cadastrar(Medico novoMedico);

        /// <summary>
        /// Atualiza um usuário existente passando id pelo corpo da requisição
        /// </summary>
        /// <param name="id"> id da medico a ser atualizado</param>
        /// <param name="medicoAtualizada"> Objeto medico a ser atualizado</param>
        void Atualizar(int id, Medico medicoAtualizada);

        /// <summary>
        /// Deleta um medico
        /// </summary>
        /// <param name="id">Id do medico a ser deletado</param>
        void Deletar(int id);
    }
}
