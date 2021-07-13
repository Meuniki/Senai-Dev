﻿using CzBooks_WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CzBooks_WebApi.Interfaces
{
    /// <summary>
    /// Interface responsavel pelo repositorio Livraria
    /// </summary>
    interface ILivrariaRepository
    {
        /// <summary>
        /// Lista todas livraria
        /// </summary>
        /// <returns>Uma lista de livraria</returns>
        List<Livraria> Listar();

        /// <summary>
        /// Busca uma livraria atraves do seu ID
        /// </summary>
        /// <param name="id">ID da livraria que será buscada</param>
        Livraria BuscaPorId(int id);

        /// <summary>
        /// Cadastra uma novo livraria
        /// </summary>
        /// <param name="novaLivraria">Objeto novoLivraria que será cadastrado</param>
        void Cadastrar(Livraria novaLivraria);

        /// <summary>
        /// Deleta uma livraria existente
        /// </summary>
        /// <param name="id">ID da livraria que será deletado</param>
        void Deletar(int id);
    }
}
