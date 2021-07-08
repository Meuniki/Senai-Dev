using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SpMedicalGroup_WebApi.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Medicos = new HashSet<Medico>();
            Pacientes = new HashSet<Paciente>();
        }

        public int IdUsuario { get; set; }

        [Required (ErrorMessage ="Email é obrigatório")]
        public string Email { get; set; }

        [Required (ErrorMessage = "Senha é obrigatória")]
        [StringLength(20, MinimumLength = 3, ErrorMessage =" O campo senha deve ter no mínimo 3 caracteres")]
        public string Senha { get; set; }
        public int? IdTipoUsuario { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Medico> Medicos { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
