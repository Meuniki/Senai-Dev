using System;
using System.Collections.Generic;

#nullable disable

namespace CzBooks_WebApi.Domains
{
    public partial class Autor
    {
        public Autor()
        {
            Livros = new HashSet<Livro>();
        }

        public int IdAutor { get; set; }
        public int? IdUsuario { get; set; }
        public string Nome { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }
    }
}
