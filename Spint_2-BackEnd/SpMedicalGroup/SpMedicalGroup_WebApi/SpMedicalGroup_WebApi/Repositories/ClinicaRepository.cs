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
    /// Classe responsável pelo repositório da Clinica
    /// </summary>
    public class ClinicaRepository : IClinicaRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamado od métodos
        /// </summary>
        SpMedicalContext ctx = new SpMedicalContext();

        /// <summary>
        /// Atualizauma clinica existente
        /// </summary>
        /// <param name="id">ID da clinica que será atualizada</param>
        /// <param name="clinicaAtualizada">Objeto clinicaAtualizada com as novas informações</param>
        public void Atualizar(int id, Clinica clinicaAtualizada){

            Clinica clinicaBuscada = ctx.Clinicas.Find(id);

            if (clinicaAtualizada.Nome != null){
                clinicaBuscada.Nome = clinicaAtualizada.Nome;
            }

            if (clinicaAtualizada.Cnpj != null){
                clinicaBuscada.Cnpj = clinicaAtualizada.Cnpj;
            }

            if (clinicaAtualizada.RazaoSocial != null){
                clinicaBuscada.RazaoSocial = clinicaAtualizada.RazaoSocial;
            }

            if (clinicaAtualizada.Endereco != null){
                clinicaBuscada.Endereco = clinicaAtualizada.Endereco;
            }

            ctx.Clinicas.Update(clinicaBuscada);

            ctx.SaveChanges();
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
