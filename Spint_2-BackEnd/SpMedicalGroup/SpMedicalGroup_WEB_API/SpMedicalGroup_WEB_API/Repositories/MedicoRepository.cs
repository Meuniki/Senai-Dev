using SpMedicalGroup_WebApi.Domains;
using SpMedicalGroup_WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private string stringConexao = "Data Source=LAB08DESK2701\\SQLEXPRESS01; initial catalog=SpMedicalGroup; integrated security=true ";

        public void Atualizar(MedicoDomain medico)
        {
            throw new NotImplementedException();
        }

        public List<MedicoDomain> BuscarPorIs(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(MedicoDomain novoMedico)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<MedicoDomain> ListarTodos()
        {
            List<MedicoDomain> listaMedico = new List<MedicoDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string querySelectAll = "SELECT IdMedico, CRM, Nome, IdEspecialidade, IdClinica, IdUsuario FROM Medicos;";

                // Abre conexão com banco de dados
                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {

                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        MedicoDomain medico = new MedicoDomain()
                        {

                            IdMedico = Convert.ToInt32(rdr[0]),
                            CRM = rdr[1].ToString(),
                            Nome = rdr[2].ToString(),
                            IdEspecialidade = Convert.ToInt32(rdr[3]),
                            IdClinica = Convert.ToInt32(rdr[4]),
                            IdUsuario = Convert.ToInt32(rdr[5])
                        };

                        // Adiciona o objeto medico à listaMedico
                        listaMedico.Add(medico);
                    }
                }
            }
            //Retorna a lista de Medicos
            return listaMedico;
        }
    }
}
