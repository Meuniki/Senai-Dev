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
        /// Valida o usuário
        /// </summary>
        /// <param name="email">e-mail do usuário</param>
        /// <param name="senha">senha do usuário</param>
        /// <returns>Um objeto do tipo usuário que foi busacado </returns>
        Usuario Login(string email, string senha);
        /// <summary>
        /// Retorna Todos Usuarios
        /// </summary>
        /// <returns>Uma lista de Usuarios</returns>
        List<Usuario> ListarTodos();

        /// <summary>
        /// Busca um Usuario através do seu id
        /// </summary>
        /// <param name="id">id do usuario a ser buscado</param>
        /// <returns>Um objeto do tiopo Usuario que foi buscado</returns>
        Usuario BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo objeto Usuario
        /// </summary>
        /// <param name="novoUsuario">Objeto Usuario que será cadastrado</param>
        void Cadastrar(Usuario novoUsuario);

        /// <summary>
        /// Atualiza um usuário existente passando id pelo corpo da requisição
        /// </summary>
        /// <param name="id"> id da usuario a ser atualizado</param>
        /// <param name="usuarioAtualizada"> Objeto usuario a ser atualizado</param>
        void Atualizar(int id, Usuario usuarioAtualizada);

        /// <summary>
        /// Deleta um usuario
        /// </summary>
        /// <param name="id">Id do usuário a ser deletado</param>
        void Deletar(int id);
    }
}
