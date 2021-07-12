using CzBooks_WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CzBooks_WebApi.Interfaces
{
    interface ILivroRepository
    {
        /// <summary>
        /// Lista todos livros
        /// </summary>
        /// <returns>Uma lista de livros</returns>
        List<Livro> Listar();

        /// <summary>
        /// Lista todos livros deu um autor
        /// </summary>
        /// <param name="id">ID do autor que será buscado</param>
        /// <returns>Uma lista de livros de um determinado autor</returns>
        List<Livro> ListarMeus( int id);

        /// <summary>
        /// Busca um usuário atracés do deu ID
        /// </summary>
        /// <param name="id">ID do usuário que será buscado</param>
        /// <returns>Um usuário buscado</returns>
        Livro BuscaPorId(int id);

        /// <summary>
        /// Cadastra Um novo usuário
        /// </summary>
        /// <param name="novoLivro">Objeto novoLivro que será cadastrado</param>
        void Cadastrar(Livro novoLivro);

        /// <summary>
        /// Deleta um usuário existente
        /// </summary>
        /// <param name="id">ID do usuário que será deletado</param>
        void Deletar(int id);


    }
}
