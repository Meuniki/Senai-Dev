using CzBooks_WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CzBooks_WebApi.Interfaces
{
    interface ICategoriaRepository
    {
        /// <summary>
        /// Lista todas categorias
        /// </summary>
        /// <returns>Uma lista de categorias</returns>
        List<Categoria> Listar();

        /// <summary>
        /// Busca uma categoria através do deu ID
        /// </summary>
        /// <param name="id">ID da categoria que será buscado</param>
        /// <returns>Uma categoria buscado</returns>
        Categoria BuscaPorId(int id);

        /// <summary>
        /// Cadastra uma novo categoria
        /// </summary>
        /// <param name="novoCategoria">Objeto novoCategoria que será cadastrado</param>
        void Cadastrar(Categoria novoCategoria);

        /// <summary>
        /// Deleta uma categoria existente
        /// </summary>
        /// <param name="id">ID da categoria que será deletado</param>
        void Deletar(int id);
    }
}
