using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Domains
{
    /// <summary>
    /// A clsse que representa a entidade clinica
    /// </summary>
    public class ClinicaDomain
    {
        public int IdClinica { get; set; }

        public string Nome { get; set; }

        public string CNPJ { get; set; }

        public string RazaoSocial { get; set; }

        public string Endereco { get; set; }
    }
}
