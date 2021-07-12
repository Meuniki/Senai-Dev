using CzBooks_WebApi.Contexts;
using CzBooks_WebApi.Domains;
using CzBooks_WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CzBooks_WebApi.Repositories
{
    public class LivrariaRepository : ILivrariaRepository
    {
        CzbooksContext ctx = new CzbooksContext();

        public Livraria BuscaPorId(int id)
        {
            return ctx.Livrarias.FirstOrDefault(e => e.IdLivraria == id);
        }

        /// <summary>
        /// Cadastra uma nova livraria
        /// </summary>
        /// <param name="novoLivraria">Objeto novaCategora que será cadastrada</param>
        public void Cadastrar(Livraria novoLivraria)
        {
            ctx.Livrarias.Add(novoLivraria);

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
        /// Lista todas Livrarias
        /// </summary>
        /// <returns>Retorna uma lista de livrarias</returns>
        public List<Livraria> Listar()
        {
            return ctx.Livrarias.ToList();
        }
    }
}
