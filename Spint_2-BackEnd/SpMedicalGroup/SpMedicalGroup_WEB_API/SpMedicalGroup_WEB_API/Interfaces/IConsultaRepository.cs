using SpMedicalGroup_WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Interfaces
{
    /// <summary>
    /// Interface responsavel pelo repositorio ConsultaRepository
    /// </summary>
    public interface IConsultaRepository
    {
        /// <summary>
        /// Retorna Todas consultas
        /// </summary>
        /// <returns>Uma lista de consultas</returns>
        List<ConsultaDomain> ListarTodos();

        /// <summary>
        /// Busca uma consulta através do seu id
        /// </summary>
        /// <param name="id">id da consulta a ser buscado</param>
        /// <returns>Um objeto do tipo ConsultaDomain que foi buscado</returns>
        List<ConsultaDomain> BuscarPorIs(int id);

        /// <summary>
        /// Cadastra um novo objeto ConsultaDomain
        /// </summary>
        /// <param name="novoConsulta">Objeto ConsultaDomain que será cadastrado</param>
        void Cadastrar(ConsultaDomain novoConsulta);

        /// <summary>
        /// Atualiza uma consulta existente passando id pelo corpo da requisição
        /// </summary>
        /// <param name="consulta">Objeto usuário a ser atualizado</param>
        void Atualizar(ConsultaDomain consulta);

        /// <summary>
        /// Deleta uma consulta
        /// </summary>
        /// <param name="id">Id da consulta a ser deletado</param>
        void Deletar(int id);
    }
}
