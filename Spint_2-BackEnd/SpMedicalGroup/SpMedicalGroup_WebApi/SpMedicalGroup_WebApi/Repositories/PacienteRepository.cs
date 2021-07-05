using SpMedicalGroup_WebApi.Contexts;
using SpMedicalGroup_WebApi.Domains;
using SpMedicalGroup_WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Repositories
{
    /// <summary>
    /// Classe responsável pelo repositório do Paciente
    /// </summary>
    public class PacienteRepository : IPacienteRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamado od métodos
        /// </summary>
        SpMedicalContext ctx = new SpMedicalContext();
        
        public void Atualizar(int id, Paciente pacienteAtualizada)
        {
            throw new NotImplementedException();
        }

        public Paciente BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Paciente novoPaciente)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lista todos os pacientes
        /// </summary>
        /// <returns> Uma lista de pacientes</returns>
        public List<Paciente> ListarTodos()
        {
            return ctx.Pacientes.ToList();
        }
    }
}
