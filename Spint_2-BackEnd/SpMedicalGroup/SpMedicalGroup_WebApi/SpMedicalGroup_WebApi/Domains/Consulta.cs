using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SpMedicalGroup_WebApi.Domains
{
    public partial class Consulta
    {
        public int IdConsulta { get; set; }

        [Required(ErrorMessage = "Deve haver um paciente")]
        public int? IdPaciente { get; set; }

        [Required(ErrorMessage ="Deve haver um medico")]
        public int? IdMedico { get; set; }

        [Required(ErrorMessage ="Deve haver uma data")]
        public DateTime DataConsulta { get; set; }

        [Required(ErrorMessage ="Deve haver uma Situação")]
        public string Situacao { get; set; }
        public string Descricao { get; set; }

        public virtual Medico IdMedicoNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
    }
}
