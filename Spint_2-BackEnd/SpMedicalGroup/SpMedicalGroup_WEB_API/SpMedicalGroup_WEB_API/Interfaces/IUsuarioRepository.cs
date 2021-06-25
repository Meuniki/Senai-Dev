using SpMedicalGroup_WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Interfaces
{
    /// <summary>
    /// Inteface responsável pelo repositório UsuarioRepository
    /// </summary>
    public interface IUsuarioRepository
    {
        /// <summary>
        /// Retorna Todos Usuarios
        /// </summary>
        /// <returns>Uma lista de Usuarios</returns>
        List<UsuarioDomain> ListarTodos();

        /// <summary>
        /// Busca um Usuario através do seu id
        /// </summary>
        /// <param name="id">id do usuario a ser buscado</param>
        /// <returns>Um objeto do tiopo UsuarioDomain que foi buscado</returns>
        List<UsuarioDomain> BuscarPorIs(int id);

        /// <summary>
        /// Cadastra um novo objeto UsuarioDomain
        /// </summary>
        /// <param name="novoUsuario">Objeto UsuarioDomain que será cadastrado</param>
        void Cadastrar(UsuarioDomain novoUsuario);

        /// <summary>
        /// Atualiza um usuário existente passando id pelo corpo da requisição
        /// </summary>
        /// <param name="usuario">Objeto usuário a ser atualizado</param>
        void Atualizar(UsuarioDomain usuario);

        /// <summary>
        /// Deleta um usuario
        /// </summary>
        /// <param name="id">Id do usuário a ser deletado</param>
        void Deletar(int id);
    }
}
