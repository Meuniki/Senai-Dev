using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedicalGroup_WebApi.Domains
{
    /// <summary>
    /// A classe que representa a entidadee Consulta
    /// </summary>
    public class ConsultaDomain
    {
        public int IdConsulta { get; set; }

        public DateTime DataConsulta { get; set; }

        public string Situacao { get; set; }

        public string Descricao { get; set; }

        public int IdMedico { get; set; }

        public int IdPaciente { get; set; }

    }
}
