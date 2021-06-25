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
        List<MedicoDomain> ListarTodos();

        /// <summary>
        /// Busca um medico através do seu id
        /// </summary>
        /// <param name="id">id do medico a ser buscado</param>
        /// <returns>Um objeto do tipo MedicoDomain que foi buscado</returns>
        List<MedicoDomain> BuscarPorIs(int id);

        /// <summary>
        /// Cadastra um novo objeto MedicoDomain
        /// </summary>
        /// <param name="novoMedico">Objeto MedicoDomain que será cadastrado</param>
        void Cadastrar(MedicoDomain novoMedico);

        /// <summary>
        /// Atualiza um medico existente passando id pelo corpo da requisição
        /// </summary>
        /// <param name="medico">Objeto usuário a ser atualizado</param>
        void Atualizar(MedicoDomain medico);

        /// <summary>
        /// Deleta um medico
        /// </summary>
        /// <param name="id">Id do medico a ser deletado</param>
        void Deletar(int id);
    }
}
