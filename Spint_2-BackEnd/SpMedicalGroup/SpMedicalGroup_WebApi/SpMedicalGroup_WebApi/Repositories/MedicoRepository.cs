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
    /// Classe responsável pelo repositório do medico
    /// </summary>
    public class MedicoRepository : IMedicoRepository
    {
        SpMedicalContext ctx = new SpMedicalContext();
        public void Atualizar(int id, Medico medicoAtualizada)
        {
            throw new NotImplementedException();
        }

        public Medico BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Medico novoMedico)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lista todos os Medicos
        /// </summary>
        /// <returns> Uma lista de Medicos</returns>
        public List<Medico> ListarTodos()
        {
            return ctx.Medicos.ToList();
        }
    }
}
