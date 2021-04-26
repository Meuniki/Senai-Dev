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
    /// Classe responsavel pelo repositório dos gêneros
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {

        /// <summary>
        /// String de conexão de dados que recebe os parâmetros
        /// Data Source = Nome do servidaor
        /// Initial catalogo = Nome do Banco
        /// Integrated security = Uda
        /// </summary>
        private string stringConexao = "Data Source=DESKTOP-RSQ1KON; initial catalog=Filmes; integrated security=true";

        public void AtualizarIdCorpo(GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int id, GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public GeneroDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cadastra um novo gênero
        /// </summary>
        /// <param name="novoGenero"> Objeto novoGenero com as informações que serão cadastradas</param>
        public void Cadastrar(GeneroDomain novoGenero)
        {
            // Declara a SqlConnection con passando a string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // INSERT INTO Generos(Nome) VALUES('Aventura');
                // INSERT INTO Generos(Nome) VALUES('Joana D'Arc');
                // string queryInsert = "INSERT INTO Generos(Nome) VALUES('" + novoGenero.nome + "')";
                // Não Passar dessa forma, pde causar o erro Joana D'Arc
                // Além de permitir SQL injection
                // Por exemplo
                // "nome" : "')DROP TABLE Filmes--"
                // Ao tentar cadastrar o comando de acima, irá deletar a tabela Filmes do Banco 

                string queryInsert = "INSERT INTO Generos(Nome) VALUES(@Nome)";

                // Declara o SqlCommand cmd passando a querry que será executada e a conexão como parametro
                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    //Passa o valor para o parametro @Nome
                    cmd.Parameters.AddWithValue("@Nome", novoGenero.nome);

                    // Abre a conexão com o Banco
                    con.Open();

                    // Executa a querry
                    cmd.ExecuteNonQuery();
                }


            }
        }

        public void Deletar(int id)
        {
            // Declara a SqlConnection con passando a string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {

            }
                throw new NotImplementedException();
        }

        /// <summary>
        /// Lista todos os gêneros
        /// </summary>
        /// <returns>Uma lista de gÊneros</returns>
        public List<GeneroDomain> ListarTodos()
        {
            // Cria uma lista listaGenero onde serão armazenado os generos
            List<GeneroDomain> listaGeneros = new List<GeneroDomain>();

            // Declara a SqlConnection con passando a string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara instrunção a ser executada
                string querrySelectAll = "SELECT idGenero, Nome FROM Generos";

                // Abre conexão com o Banco 
                con.Open();

                // Declara o SqlDataReader rdr para percorrer a tabela do Banco
                SqlDataReader rdr;

                // Declara o SqlCommand cmd passando a querry que será executada e a conexao com 
                using (SqlCommand cmd = new SqlCommand(querrySelectAll))
                {
                    // Executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();

                    // Enquanto ouver registros para serem lidosno rdr, o laço se repete
                    while (rdr.Read())
                    {
                        // Instancia um objeto genero do tipo GeneroDomain
                        GeneroDomain genero = new GeneroDomain()
                        {
                            // Atribui à propriedade idGEnero o valor da primeira coluna da tabela do Banco 
                            idGenero = Convert.ToInt32(rdr[0]),

                            // Atribui À propriedade nome o valor da segunda coluna da tabela do Banco
                            nome = rdr[1].ToString()
                        };

                        // Adiciona o objetivo genero à lista listaGeneros
                        listaGeneros.Add(genero);
                    }
                }

            }
            // REtorna a lista de gêneros
            return listaGeneros;
        }
    }
}