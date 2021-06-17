using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace senai.inlock.webApi.Domains{

    /// <summary>
    /// Classe que representa a entidade(Tabela) Usuário
    /// </summary>
    public class UsuarioDomain{

        public int idUsuario { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string senha { get; set; }

        public int idTipoUsuario { get; set; }
    }
}
