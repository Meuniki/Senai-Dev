using System.Collections.Generic;
using senai_filmes_webApi.Domains;

namespace senai_filmes_webApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório GeneroRepository
    /// </summary>
    public interface IGeneroRepository
    {
        // TipoRetorno NomeMetodo(TipoParâmetro NomeParâmetro);
        // void Cadastrar();

        /// <summary>
        /// Retornar todos os gêneros
        /// </summary>
        /// <returns>Uma lista de gêneros</returns>
        List<GeneroDomain> ListarTodos();

        /// <summary>
        /// Busca um gênero através do seu id
        /// </summary>
        /// <param name="id">id do gênero que vai será buscado</param>
        /// <returns>Um objeto do tipo GeneroDomain que foi buscado</returns>
        GeneroDomain BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo gênero
        /// </summary>
        /// <param name="novoGenero">Objeto novoGenero que será cadastrado</param>
        void Cadastrar(GeneroDomain novoGenero);

        /// <summary>
        /// Atualiza um gênero existente passando o id pelo corpo da requisição
        /// </summary>
        /// <param name="genero">Objeto genero que será atualizado</param>
        void AtualizarIdCorpo(GeneroDomain genero);

        /// <summary>
        /// Atuaiza um gênero existente passando id pela url da requisição
        /// </summary>
        /// <param name="id">Id do gênero do genero que será atualizado</param>
        /// <param name="genero">Objeto com novas informações</param>
        void AtualizarIdUrl(int id, GeneroDomain genero);

        /// <summary>
        /// Deleta um gênero
        /// </summary>
        /// <param name="id">Id do gênero que será deletado</param>
        void Deletar(int id);
    }
}
