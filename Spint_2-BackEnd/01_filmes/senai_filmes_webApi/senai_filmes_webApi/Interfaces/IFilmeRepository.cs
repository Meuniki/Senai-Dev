using System.Collections.Generic;
using senai_filmes_webApi.Domains;

namespace senai_filmes_webApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório FilmeRepository
    /// </summary>
    public interface IFilmeRepository
    {

        /// <summary>
        /// Retornar todos os filmes
        /// </summary>
        /// <returns>Uma lista de filmes</returns>
        List<FilmeDomain> ListarTodos();

        /// <summary>
        /// Busca um filme através do seu id
        /// </summary>
        /// <param name="id">id do filme que vai será buscado</param>
        /// <returns>Um objeto do tipo FilmeDomain que foi buscado</returns>
        FilmeDomain BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo filme
        /// </summary>
        /// <param name="novoFilme">Objeto novoFilme que será cadastrado</param>
        void Cadastrar(FilmeDomain novoFilme);

        /// <summary>
        /// Atualiza um filme existente passando o id pelo corpo da requisição
        /// </summary>
        /// <param name="filme">Objeto filme que será atualizado</param>
        void AtualizarIdCorpo(FilmeDomain filme);

        /// <summary>
        /// Atuaiza um filme existente passando id pela url da requisição
        /// </summary>
        /// <param name="id">Id do filme do filme que será atualizado</param>
        /// <param name="filme">Objeto com novas informações</param>
        void AtualizarIdUrl(int id, FilmeDomain filme);

        /// <summary>
        /// Deleta um filme
        /// </summary>
        /// <param name="id">Id do filme que será deletado</param>
        void Deletar(int id);
    }
}
