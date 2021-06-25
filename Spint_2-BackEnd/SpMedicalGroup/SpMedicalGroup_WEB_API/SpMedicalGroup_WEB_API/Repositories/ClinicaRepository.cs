using SpMedicalGroup_WebApi.Domains;
using SpMedicalGroup_WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Repositories
{
    /// <summary>
    /// Classe responsável pelo repositório da Clinica
    /// </summary>
    public class ClinicaRepository : IClinicaRepository
    {
        private string stringConexao = "Data Source=LAB08DESK2701\\SQLEXPRESS01; initial catalog=SpMedicalGroup; integrated security=true ";

        public void Atualizar(ClinicaDomain clinica)
        {
            throw new NotImplementedException();
        }

        public List<ClinicaDomain> BuscarPorIs(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(ClinicaDomain novoClinica)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lista todos as clinicas
        /// </summary>
        /// <returns>Uma lista com todas as clinicas</returns>
        public List<ClinicaDomain> ListarTodos(){

            List<ClinicaDomain> listaClinica = new List<ClinicaDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao)){

                string querySelectAll = "SELECT IdClinica, Nome, CNPJ, RazaoSocial, Endereco  FROM Clinicas";
                
                // Abre conexão com banco de dados
                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con)){

                    rdr = cmd.ExecuteReader();

                    while (rdr.Read()){

                        ClinicaDomain clinica = new ClinicaDomain(){

                            IdClinica = Convert.ToInt32(rdr[0]),
                            Nome = rdr[1].ToString(),
                            CNPJ = rdr[2].ToString(),
                            RazaoSocial = rdr[3].ToString(),
                            Endereco = rdr[4].ToString()
                        };

                        // Adiciona o objeto clinica à listaClinica
                        listaClinica.Add(clinica);
                    }
                }
            }
            //Retorna a lista de Clinicas
            return listaClinica;
        }
    }
}
