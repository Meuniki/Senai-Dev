using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade TioUsuario
    /// </summary>
    public class TipoUsuarioDomain
    {
        public int IdTipoUsuario { get; set; }

        public string Tipo { get; set; }
    }
}
