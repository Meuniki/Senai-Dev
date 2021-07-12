using CzBooks_WebApi.Contexts;
using CzBooks_WebApi.Domains;
using CzBooks_WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CzBooks_WebApi.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        CzbooksContext ctx = new CzbooksContext();

        public Livro BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Livro novoLivro)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Livro> Listar()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lista todos os eventos que um determinado livro participa
        /// </summary>
        /// <param name="id">ID do livro que participa dos eventos listados</param>
        /// <returns>
        //public List<Livro> ListarMeus(int id)
        //{
        //    return ctx.Livros

        //    .Include(p => p.IdAutorNavigation)
        //    .Where(p => p.I)
        //    .ToList();
        //}
    }
}
