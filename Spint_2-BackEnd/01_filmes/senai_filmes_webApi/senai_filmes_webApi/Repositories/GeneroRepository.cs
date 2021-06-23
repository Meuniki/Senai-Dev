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
        /// user id=sa; pwd=senai@132 = Faz a autenticação com o usuário do SQL Server, passando logon e senha
        /// Integrated security = Faz a autenticação com o usuário do Sistema (Windows)
        /// </summary>
        private string stringConexao = "Data Source=LAB08DESK115999\\SQLEXPRESS; initial catalog=Filmes; integrated security=true";

        /// <summary>
        /// Atualiza um gênero passando o id pelo corpo
        /// </summary>
        /// <param name="genero">Objeto gênero com as novas informações</param>
        public void AtualizarIdCorpo(GeneroDomain genero)
        {

            //Declara a SqlConnection con passando a string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                
                // Declara a query a ser executada
                string queryUpdateIdBody = "UPDATE Generos SET Nome = @Nome WHERE idGenero = @ID";

                // Declara o SqlCommand cmd passando a querry que será executada e a conexão como parametro
                using (SqlCommand cmd = new SqlCommand(queryUpdateIdBody, con))
                {
                    // Passa os valores para os parâmetro
                    cmd.Parameters.AddWithValue("@Nome", genero.nome);
                    cmd.Parameters.AddWithValue("@ID", genero.idGenero);

                    // Abre a conexão com o Banco
                    con.Open();

                    // Executa a querry
                    cmd.ExecuteNonQuery();
                }
            }
        
        }

        /// <summary>
        /// Atualiza um gênero passando o id pelo recurso (URL)
        /// </summary>
        /// <param name="id">id do gênero que será atualizado</param>
        /// <param name="genero">Objeto gênero com as novas informações</param>
        public void AtualizarIdUrl(int id, GeneroDomain genero)
        {
            //Declara a SqlConnection con passando a string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a query a ser executada
                string queryUpdateUrl = "UPDATE Generos SET Nome = @Nome WHERE idGenero = @ID";

                // Declara o SqlCommand cmd passando a querry que será executada e a conexão como parametro
                using (SqlCommand cmd = new SqlCommand(queryUpdateUrl, con))
                {
                    // Passa os valores para os parâmetro
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Nome", genero.nome);

                    // Abre a conexão com o Banco
                    con.Open();

                    // Executa a querry
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Busca um gênero através do seu id
        /// </summary>
        /// <param name="id">id do gênero que sera buscado</param>
        /// <returns>Um gênero buscado ou null caso não encontrado</returns>
        public GeneroDomain BuscarPorId(int id)
        {
            //DEclara a SqlConnection con passando a string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a query a ser executada
                string querySelectById = "SELECT idGEnero, Nome FROM Generos WHERE IdGenero = @ID";

                // Abre a conexão com o banco de dados
                con.Open();

                // Declara o SqlDataReader rdr para percorrer a tabela do banco de dados
                SqlDataReader rdr;

                // Declara o SqlCommand cmd passando a querry que será executada e a conexão como parametro
                using (SqlCommand cmd = new SqlCommand(querySelectById, con))
                {
                    // Passa o valor para o parâmetro @ID
                    cmd.Parameters.AddWithValue("@ID", id);

                    //Executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();

                    //Verifica se o resultado da query retornou algum registro
                    if (rdr.Read())
                    {
                        // Se sim, instancia um  novo objeto generoBuscado do tipo GeneroDomain
                        GeneroDomain generoBuscado = new GeneroDomain
                        {
                            // Atribui à propriedade idGenero o valor da coluna "idGenero da tabela do banco de dados"
                            idGenero = Convert.ToInt32(rdr["idGenero"]),

                            // Atribui à propriedade nome o valor da coluna "Nome da tabela do banco de dados"
                            nome = rdr["Nome"].ToString()
                        };

                        // Retorna o generoBuscado com os daos obtidos
                        return generoBuscado;
                    }

                    // Se não, retorna null
                    return null;
                }
            }
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

        /// <summary>
        /// Deleta um gênero pelo seu id
        /// </summary>
        /// <param name="id">id do gêneo que será deletado</param>
        public void Deletar(int id)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a query a ser executada passando o valor como parâmetro
                string queryDelete = "DELETE FROM Generos WHERE idGenero = @ID";

                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
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
        /// Lista todos os gêneros
        /// </summary>
        /// <returns>Uma lista de gêneros</returns>
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

                // Declara o SqlDataReader rdr para percorrer a tabela do banco de dados
                SqlDataReader rdr;

                // Declara o SqlCommand cmd passando a querry que será executada e a conexão como parâmetros
                using (SqlCommand cmd = new SqlCommand(querrySelectAll, con))
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
