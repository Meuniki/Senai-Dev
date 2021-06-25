using SpMedicalGroup_WebApi.Domains;
using SpMedicalGroup_WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private string stringConexao = "Data Source=LAB08DESK2701\\SQLEXPRESS01; initial catalog=SpMedicalGroup; integrated security=true ";

        public void Atualizar(ConsultaDomain consulta)
        {
            throw new NotImplementedException();
        }

        public List<ConsultaDomain> BuscarPorIs(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(ConsultaDomain novoConsulta)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<ConsultaDomain> ListarTodos()
        {
            List<ConsultaDomain> listaConsulta = new List<ConsultaDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string querySelectAll = "SELECT IdConsulta, DataConsulta, Situacao, Descricao, IdMedico, IdPaciente FROM Consultas";

                // Abre conexão com banco de dados
                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {

                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        ConsultaDomain consulta = new ConsultaDomain()
                        {

                            IdConsulta = Convert.ToInt32(rdr[0]),
                            DataConsulta = Convert.ToDateTime(rdr[1]),
                            Situacao = rdr[2].ToString(),
                            Descricao = rdr[3].ToString(),
                            IdMedico = Convert.ToInt32(rdr[4]),
                            IdPaciente = Convert.ToInt32(rdr[5])
                        };

                        // Adiciona o objeto consulta à listaConsulta
                        listaConsulta.Add(consulta);
                    }
                }
            }
            //Retorna a lista de Consultas
            return listaConsulta;
        }
    }
}
