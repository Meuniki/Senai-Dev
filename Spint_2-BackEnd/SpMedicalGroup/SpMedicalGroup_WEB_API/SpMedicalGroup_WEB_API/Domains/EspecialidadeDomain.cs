using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Domains
{
    /// <summary>
    /// A classe que representa a entidade Especialidade
    /// </summary>
    public class EspecialidadeDomain
    {
        public int IdEspecialidade { get; set; }

        public string Nome { get; set; }
    }
}
