using SpMedicalGroup_WebApi.Contexts;
using SpMedicalGroup_WebApi.Domains;
using SpMedicalGroup_WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamado od métodos
        /// </summary>
        SpMedicalContext ctx = new SpMedicalContext();

        public void Atualizar(int id,Consulta consultaAtualizada)
        {

            Consulta consultaBuscada = ctx.Consultas.Find(id);

            if (consultaAtualizada.IdPaciente != null)
            {
                consultaBuscada.IdPaciente = consultaAtualizada.IdPaciente;
            }

            if (consultaAtualizada.IdMedico != null)
            {
                consultaBuscada.IdMedico = consultaAtualizada.IdMedico;
            }

            if (consultaAtualizada.DataConsulta >= DateTime.Now)
            {
                consultaBuscada.DataConsulta = consultaAtualizada.DataConsulta;
            }

            if (consultaAtualizada.Situacao != null)
            {
                consultaBuscada.Situacao = consultaAtualizada.Situacao;
            }
            
            if (consultaAtualizada.Descricao != null)
            {
                consultaBuscada.Descricao = consultaAtualizada.Descricao;
            }

            ctx.Consultas.Update(consultaBuscada);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Busca uma consulta atravás do seu ID
        /// </summary>
        /// <param name="id"> ID da consulta que será buscada</param>
        /// <returns>Uma consulta buscada</returns>
        public Consulta BuscarPorId(int id)
        {
            // Retorna a primeira consulta encontrada para o ID informado
            return ctx.Consultas.FirstOrDefault(e => e.IdConsulta == id);
        }

        public Consulta BuscaUmMedico(int id)
        {
            return ctx.Consultas.FirstOrDefault(e => e.IdMedico == id);
        }

        public Consulta BuscaUmPaciente(int id)
        {
            return ctx.Consultas.FirstOrDefault(e => e.IdPaciente == id);
        }

        /// <summary>
        /// Cadastra uma nova consulta
        /// </summary>
        /// <param name="novaConsulta">Objeto novaConsulta que será cadastrada</param>
        public void Cadastrar(Consulta novaConsulta)
        {
            // Adiciona este novaConsulta
            ctx.Consultas.Add(novaConsulta);

            // Salva as informações para serem gravadas no banco de dados
            ctx.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Deletar(int id)
        {
            // Remove a consulta que foi buscado
            ctx.Consultas.Remove(BuscarPorId(id));

            // Salva as alterações
            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista todas as consultas
        /// </summary>
        /// <returns> Uma lista de consultas</returns>
        public List<Consulta> ListarTodos()
        {
            return ctx.Consultas.ToList();
        }
    }
}
