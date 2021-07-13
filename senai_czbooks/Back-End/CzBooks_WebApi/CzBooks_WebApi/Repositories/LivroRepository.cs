using CzBooks_WebApi.Contexts;
using CzBooks_WebApi.Domains;
using CzBooks_WebApi.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CzBooks_WebApi.Repositories
{
    /// <summary>
    /// Classe responsável pelo repositorio livro
    /// </summary>
    public class LivroRepository : ILivroRepository
    {
        CzbooksContext ctx = new CzbooksContext();

        /// <summary>
        /// Busca um livro pelo seu ID
        /// </summary>
        /// <param name="id">ID do livro que será buscado</param>
        /// <returns>Um objeto livro</returns>
        public Livro BuscaPorId(int id)
        {
            return ctx.Livros.FirstOrDefault(e => e.IdLivro == id);
        }

        /// <summary>
        /// Cadastra um nova livro
        /// </summary>
        /// <param name="novaLivro">Objeto novaLivro que será cadastrado</param>
        public void Cadastrar(Livro novaLivro)
        {
            ctx.Livros.Add(novaLivro);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Deleta um livro
        /// </summary>
        /// <param name="id">ID do livro que será deletado</param>
        public void Deletar(int id)
        {
            ctx.Livros.Remove(BuscaPorId(id));

            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista todos livros
        /// </summary>
        /// <returns>Retorna uma lista de livros</returns>
        public List<Livro> Listar()
        {
            return ctx.Livros.ToList();
        }

        ///<summary>
        /// Lista todos os livros que um determinado autor escreveu
        /// </summary>
        /// <param name="id">ID do autor que escreveu os livros listados</param>
        /// <returns>Retorna uma lista de livros</returns>
        public List<Livro> ListarMeus(int id)
        {
            return ctx.Livros

            .Include(p => p.IdAutorNavigation)
            .Include(p => p.IdCategoriaNavigation)
            .Include(p => p.IdLivrariaNavigation)
            .Where(p => p.IdAutorNavigation.IdAutor == id)
            .ToList();
        }
    }
}