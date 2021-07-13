using System;
using System.Collections.Generic;

#nullable disable

namespace CzBooks_WebApi.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Autores = new HashSet<Autor>();
        }

        public int IdUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Autor> Autores { get; set; }
    }
}
