using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Domains
{
    /// <summary>
    /// A classe que representa a entidade Paciente
    /// </summary>
    public class PacienteDomain
    {
        public int IdPaciente { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Telefone { get; set; }

        public string RG { get; set; }

        public string CPF { get; set; }

        public string Endereco { get; set; }

        public int IdUsuario { get; set; }
    }
}