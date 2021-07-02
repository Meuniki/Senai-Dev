using SpMedicalGroup_WebApi.Contexts;
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
        /// <summary>
        /// Objeto contexto por onde serão chamado od métodos
        /// </summary>
        SpMedicalContext ctx = new SpMedicalContext();

        public void Atualizar(int id, Clinica clinicaAtualizada)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Busca uma clinica atravás do seu ID
        /// </summary>
        /// <param name="id"> ID da clinica que será buscada</param>
        /// <returns>Uma clinica buscada</returns>
        public Clinica BuscarPorId(int id)
        {
            // Retorna a primeira clinica encontrada para o ID informado
            return ctx.Clinicas.FirstOrDefault(e => e.IdClinica == id);
        }

        /// <summary>
        /// Cadastra uma nova clinica
        /// </summary>
        /// <param name="novaClinica">Objeto novaClinica que será cadastrada</param>
        public void Cadastrar(Clinica novaClinica)
        {
            // Adiciona este novaClinica
            ctx.Clinicas.Add(novaClinica);

            // Salva as informações para serem gravadas no banco de dados
            ctx.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Deletar(int id)
        {
            // Remove a clinica que foi buscado
            ctx.Clinicas.Remove(BuscarPorId(id));

            // Salva as alterações
            ctx.SaveChanges();

        }
        /// <summary>
        /// Lista todas as clinicas
        /// </summary>
        /// <returns> Uma lista de clinicas</returns>
        public List<Clinica> ListarTodos()
        {
            return ctx.Clinicas.ToList();
        }
    }
}
