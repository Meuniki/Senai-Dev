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
        List<Consulta> ListarTodos();

        /// <summary>
        /// Busca uma consulta através do seu id
        /// </summary>
        /// <param name="id">id da consulta a ser buscado</param>
        /// <returns>Um objeto do tipo Consulta que foi buscado</returns>
        Consulta BuscarPorId(int id);

        Consulta BuscaUmMedico(int id);

        Consulta BuscaUmPaciente(int id);

        /// <summary>
        /// Cadastra um novo objeto Consulta
        /// </summary>
        /// <param name="novoConsulta">Objeto Consulta que será cadastrado</param>
        void Cadastrar(Consulta novoConsulta);

        /// <summary>
        /// Atualiza um usuário existente passando id pelo corpo da requisição
        /// </summary>
        /// <param name="id"> id da consulta a ser atualizado</param>
        /// <param name="consultaAtualizada"> Objeto consulta a ser atualizado</param>
        void Atualizar(int id, Consulta consultaAtualizada);

        /// <summary>
        /// Deleta uma consulta
        /// </summary>
        /// <param name="id">Id da consulta a ser deletado</param>
        void Deletar(int id);
    }
}
