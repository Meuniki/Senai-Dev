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
    /// Classe responsável pelo repositorio da categoria
    /// </summary>
    public class CategoriaRepository : ICategoriaRepository
    {
        CzbooksContext ctx = new CzbooksContext();

        /// <summary>
        /// Busca uma categoria pelo seu ID
        /// </summary>
        /// <param name="id">ID da categoria que será buscada</param>
        /// <returns>Um objeto categoria</returns>
        public Categoria BuscaPorId(int id)
        {
            return ctx.Categorias.FirstOrDefault(e => e.IdCategoria == id);
        }

        /// <summary>
        /// Cadastra uma nova categoria
        /// </summary>
        /// <param name="novaCategoria">Objeto novaCategora que será cadastrada</param>
        public void Cadastrar(Categoria novaCategoria)
        {
            ctx.Categorias.Add(novaCategoria);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Deleta uma categoria
        /// </summary>
        /// <param name="id">ID da categoria que será deletada</param>
        public void Deletar(int id)
        {
            ctx.Categorias.Remove(BuscaPorId(id));

            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista todas categorias
        /// </summary>
        /// <returns>Retorna uma lista de categorias</returns>
        public List<Categoria> Listar()
        {
            return ctx.Categorias.ToList();
        }
    }
}
