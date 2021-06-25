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
    /// Classe responsável pelo repositório dos Pacientes
    /// </summary>
    public class PacienteRepository : IPacienteRepository
    {
        private string stringConexao = "Data Source=LAB08DESK2701\\SQLEXPRESS01; initial catalog=SpMedicalGroup; integrated security=true ";

        public void Atualizar(PacienteDomain paciente)
        {
            throw new NotImplementedException();
        }

        public List<PacienteDomain> BuscarPorIs(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(PacienteDomain novoPaciente)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<PacienteDomain> ListarTodos()
        {
            List<PacienteDomain> listaPaciente = new List<PacienteDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string querySelectAll = "SELECT IdPacientes, Nome, DataNascimento, Telefone, RG, CPF, Endereco, IdUsuario FROM Pacientes";

                // Abre conexão com banco de dados
                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {

                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        PacienteDomain medico = new PacienteDomain()
                        {

                            IdPaciente = Convert.ToInt32(rdr[0]),
                            Nome = rdr[1].ToString(),
                            DataNascimento = Convert.ToDateTime(rdr[2]),
                            Telefone = (rdr[3]).ToString(),
                            RG =  rdr[4].ToString(),
                            CPF = rdr[5].ToString(),
                            Endereco = rdr[6].ToString(),
                            IdUsuario = Convert.ToInt32(rdr[7])
                        };

                        // Adiciona o objeto medico à listaPaciente
                        listaPaciente.Add(medico);
                    }
                }
            }
            //Retorna a lista de Pacientes
            return listaPaciente;
        }
    }
}
