using SpMedicalGroup_WebApi.Domains;
using SpMedicalGroup_WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private string stringConexao = "Data Source=LAB08DESK2701\\SQLEXPRESS01; initial catalog=SpMedicalGroup; integrated security=true ";

        public void Atualizar(EspecialidadeDomain especialidade)
        {
            throw new NotImplementedException();
        }

        public List<EspecialidadeDomain> BuscarPorIs(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(EspecialidadeDomain novoEspecialidade)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<EspecialidadeDomain> ListarTodos()
        {
            List<EspecialidadeDomain> listaEspecialidade = new List<EspecialidadeDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string querySelectAll = "SELECT IdEspecialidade, Nome  FROM Especialidades";

                // Abre conexão com banco de dados
                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {

                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        EspecialidadeDomain especialidade = new EspecialidadeDomain()
                        {

                            IdEspecialidade = Convert.ToInt32(rdr[0]),
                            Nome = rdr[1].ToString()
                        };

                        // Adiciona o objeto especialidade à listaEspecialidade
                        listaEspecialidade.Add(especialidade);
                    }
                }
            }
            //Retorna a lista de Especialidades
            return listaEspecialidade;
        }
    }
}
