using senai_filmes_webApi.Domains;
using senai_filmes_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webApi.Repositories
{
    /// <summary>
    /// Classe responsavel pelo repositório dos filmes
    /// </summary>
    public class FilmeRepository : IFilmeRepository
    {
        /// <summary>
        /// String de conexão de dados que recebe os parâmetros
        /// </summary>
        private string stringConexao = "Data Source=LAB08DESK115999; initial catalog=Filmes; integrated security=true";

        public void AtualizarIdCorpo(FilmeDomain filme){

            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int id, FilmeDomain filme){

            throw new NotImplementedException();
        }

        public FilmeDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();

            //using (SqlConnection con = new SqlConnection(stringConexao))
            //{

            //}
        }

        /// <summary>
        /// Cadastra novo filme
        /// </summary>
        /// <param name="novoFilme">Um objeto novoFilme que serão cadastradas</param>
        public void Cadastrar(FilmeDomain novoFilme){

            using (SqlConnection con = new SqlConnection(stringConexao)){

                string queryInsert = "INSERT INTO Filmes(Titulo, idGenero) VALUES(@Titulo, @IdGenero)";

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@Titulo", novoFilme.titulo);
                    cmd.Parameters.AddWithValue("@IdGenero", novoFilme.idGenero);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Deleta um filme pelo seu id
        /// </summary>
        /// <param name="id">id do filme que será deletado</param>
        public void Deletar(int id){

            using(SqlConnection con = new SqlConnection(stringConexao)){

                // Declara a query a ser executada passando o valor como parâmetro
                string queryDelete = "DELETE FROM Generos WHERE idFilme = @ID";

                using(SqlCommand cmd = new SqlCommand(queryDelete, con)){

                    // Define o vaor do id recebido no método como o valor do parâmetro @ID
                    cmd.Parameters.AddWithValue("@ID", id);

                    //Abre  conexão com o banco de dados
                    con.Open();

                    // Executa a query
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Lista todos Filmes
        /// </summary>
        /// <returns>Uma lista de Filmes</returns>
        public List<FilmeDomain> ListarTodos(){

            List<FilmeDomain> ListaFilmes = new List<FilmeDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao)){

                string querrySelectAll = "SELECT idFilme, idGenero, Titulo FROM Filmes";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querrySelectAll, con)){

                    rdr = cmd.ExecuteReader();

                    while (rdr.Read()){

                        FilmeDomain filme = new FilmeDomain(){

                            idFilme = Convert.ToInt32(rdr[0]),
                            //idGenero = (rdr["idGenero"] as int?).GetValueOrDefault(0),
                            idGenero = Convert.ToInt32(rdr[1]),
                            titulo = rdr[2].ToString()
                        };

                    ListaFilmes.Add(filme);
                    }
                }
            }
            return ListaFilmes;
        }
    }
}
