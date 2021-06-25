using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Domains
{
    /// <summary>
    /// A classe que representa a entidade medico
    /// </summary>
    public class MedicoDomain
    {
        public int IdMedico { get; set; }

        public string CRM { get; set; }

        public string Nome { get; set; }

        public int IdEspecialidade { get; set; }

        public int IdClinica { get; set; }

        public int IdUsuario { get; set; }
    }
}
