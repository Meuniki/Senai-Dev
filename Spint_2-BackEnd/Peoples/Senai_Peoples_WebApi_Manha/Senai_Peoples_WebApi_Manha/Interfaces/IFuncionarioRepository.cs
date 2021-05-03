using Senai_Peoples_WebApi_Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Peoples_WebApi_Manha.Interfaces
{
    interface IFuncionarioRepository
    {
        /// <summary>
        /// Retorna todos funcionarios
        /// </summary>
        /// <returns>Uma lista de funcionarios</returns>
        List<FuncionarioDomain> ListarTodos();

        FuncionarioDomain BuscarPorId(int id);

        void Cadastrar(FuncionarioDomain novoFuncionario);

        void Atualizar(int id, FuncionarioDomain funcionarioAtualizado);

        void Deletar(int id);
    }
}
