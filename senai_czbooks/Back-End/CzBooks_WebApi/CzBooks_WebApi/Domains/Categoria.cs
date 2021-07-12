using System;
using System.Collections.Generic;

#nullable disable

namespace CzBooks_WebApi.Domains
{
    public partial class Categoria
    {
        public Categoria()
        {
            Livros = new HashSet<Livro>();
        }

        public int IdCategoria { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
