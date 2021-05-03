using Senai_Peoples_WebApi_Manha.Domains;
using Senai_Peoples_WebApi_Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Peoples_WebApi_Manha.Repositories{

    /// <summary>
    /// Classe Responsavel Pelo repositório dos Funcionários
    /// </summary>
    public class FuncionarioRepository : IFuncionarioRepository{

        /// <summary>
        /// String de conexão de dados que recebe os parâmetros
        /// Data Source = Nome do servidaor
        /// Initial catalogo = Nome do Banco
        /// Integrated security = Uda
        /// </summary>
        private string stringConxao = "Data Source=DESKTOP-RSQ1KON; initial catalog=M_Peoples; integrated security=true";

        /// <summary>
        /// Lista todos funcionários
        /// </summary>
        /// <returns>Uma lista de funcionários</returns>
        public List<FuncionarioDomain> ListarTodos(){

            List<FuncionarioDomain> Listafuncionarios = new List<FuncionarioDomain>();

            using (SqlConnection con = new SqlConnection(stringConxao)){

                string querySelectAll = "SELECT idFuncionarios, nome, sobrenome FROM Funcionarios";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        FuncionarioDomain funcionario = new FuncionarioDomain
                        {
                            idFuncionario = Convert.ToInt32(rdr["idFuncionarios"]),

                            nome = rdr["nome"].ToString(),

                            sobrenome = rdr["sobrenome"].ToString()
                        };
                        Listafuncionarios.Add(funcionario);
                    }
                    
                }
                
            }
            return Listafuncionarios;
        }

        /// <summary>
        /// Busca funcionário através do seu id
        /// </summary>
        /// <param name="id">id do funcionário buscado</param>
        /// <returns> Um funcionário buscado ou null caso não encontrado</returns>
        public FuncionarioDomain BuscarPorId(int id){

            using (SqlConnection con = new SqlConnection(stringConxao)){

                string querySelectById = "SELECT idFuncionarios, nome, sobrenome FROM Funcionarios WHERE idFuncionarios = @ID";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectById, con)){

                    cmd.Parameters.AddWithValue("@ID", id);

                    rdr = cmd.ExecuteReader();

                    if (rdr.Read()){

                        FuncionarioDomain funcionarioBuscado = new FuncionarioDomain{

                            idFuncionario = Convert.ToInt32(rdr[0]),
                            nome = rdr[1].ToString(),
                            sobrenome = rdr[2].ToString()
                        };
                        return funcionarioBuscado;
                    }
                    return null;
                }
            }
        }

        /// <summary>
        /// Atualiza um funcionário passadoo id pelo recurso (URL)
        /// </summary>
        /// <param name="id">id so funcionário que será atualizado</param>
        /// <param name="funcionario">Objeto funcionário com as novas informações</param>
        public void Atualizar(int id, FuncionarioDomain funcionario){

            using (SqlConnection con = new SqlConnection(stringConxao)){

                string queryUpdateUrl = "UPDATE Funcionarios SET nome = @Nome, sobrenome = @Sobrenome WHERE idFuncionarios = @ID";

                using (SqlCommand cmd = new SqlCommand(queryUpdateUrl, con)){

                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Nome", funcionario.nome);
                    cmd.Parameters.AddWithValue("@Sobrenome", funcionario.sobrenome);

                    con.Open();

                    cmd.ExecuteNonQuery();
                };
            }
        }

        
        /// <summary>
        /// Cadasra um novo funcionário
        /// </summary>
        /// <param name="novoFuncionario">Objeto novoFuncionário com as informações que serão cadastradas</param>
        public void Cadastrar(FuncionarioDomain novoFuncionario){

            using (SqlConnection con = new SqlConnection(stringConxao)){

                string queryInsert = "INSERT INTO funcionarios(nome, sobrenome) VALUES (@Nome, @Sobrenome)";

                using (SqlCommand cmd = new SqlCommand(queryInsert, con)){

                    cmd.Parameters.AddWithValue("@Nome", novoFuncionario.nome);
                    cmd.Parameters.AddWithValue("@Sobrenome", novoFuncionario.sobrenome);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Deleta um funcionário pelo seu id
        /// </summary>
        /// <param name="id">id do funcionário que será deletado</param>
        public void Deletar(int id){

            using (SqlConnection con = new SqlConnection(stringConxao)){

                string queryDelete = "DELETE FROM funcionarios WHERE idFuncionarios = @ID";

                using (SqlCommand cmd = new SqlCommand(queryDelete, con)){

                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();

                    cmd.ExecuteNonQuery();

                }
            }
        }
    }
}
