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
    /// Classe responsável pelo repositorio da livraria
    /// </summary>
    public class LivrariaRepository : ILivrariaRepository
    {
        CzbooksContext ctx = new CzbooksContext();

        /// <summary>
        /// Busca uma livraria pelo seu ID
        /// </summary>
        /// <param name="id">ID da livraria que será buscada</param>
        /// <returns>Um objeto livraria</returns>
        public Livraria BuscaPorId(int id)
        {
            return ctx.Livrarias.FirstOrDefault(e => e.IdLivraria == id);
        }

        /// <summary>
        /// Cadastra uma nova livraria
        /// </summary>
        /// <param name="novaLivraria">Objeto novaLivraria que será cadastrada</param>
        public void Cadastrar(Livraria novaLivraria)
        {
            ctx.Livrarias.Add(novaLivraria);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Deleta uma livraria
        /// </summary>
        /// <param name="id">ID da livraria que será deletada</param>
        public void Deletar(int id)
        {
            ctx.Livrarias.Remove(BuscaPorId(id));

            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista todas livrarias
        /// </summary>
        /// <returns>Retorna uma lista de livrarias</returns>
        public List<Livraria> Listar()
        {
            return ctx.Livrarias.ToList();
        }
    }
}
