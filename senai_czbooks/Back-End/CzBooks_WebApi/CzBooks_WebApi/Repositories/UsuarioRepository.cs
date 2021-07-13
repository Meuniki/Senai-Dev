using CzBooks_WebApi.Contexts;
using CzBooks_WebApi.Domains;
using CzBooks_WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CzBooks_WebApi.Repositories
{
    /// <summary>
    /// Classe responsável pelo repositorio dos usuários
    /// </summary>
    public class UsuarioRepository : IUsuarioRepository
    {
        CzbooksContext ctx = new CzbooksContext();

        /// <summary>
        /// Busca um usuário pelo seu ID
        /// </summary>
        /// <param name="id">ID do usuário que será buscado</param>
        /// <returns>Um objeto usuário</returns>
        public Usuario BuscaPorId(int id)
        {
            return ctx.Usuarios.FirstOrDefault(e => e.IdUsuario == id);
        }

        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <param name="novaUsuario">Objeto novaUsuario que será cadastrado</param>
        public void Cadastrar(Usuario novaUsuario)
        {
            ctx.Usuarios.Add(novaUsuario);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Deleta um usuário
        /// </summary>
        /// <param name="id">ID do usuário que será deletado</param>
        public void Deletar(int id)
        {
            ctx.Usuarios.Remove(BuscaPorId(id));

            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista todos usuário
        /// </summary>
        /// <returns>Retorna uma lista de usuários</returns>
        public List<Usuario> Listar()
        {
            return ctx.Usuarios.ToList();
        }

        /// <summary>
        /// Valida o usuário
        /// </summary>
        /// <param name="email">e-mail do usuário</param>
        /// <param name="senha">senha do usuário</param>
        /// <returns>Um objeto do tipo Usuario que foi buscado</returns>
        public Usuario Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
