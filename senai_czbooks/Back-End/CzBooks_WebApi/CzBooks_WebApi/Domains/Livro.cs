using System;
using System.Collections.Generic;

#nullable disable

namespace CzBooks_WebApi.Domains
{
    public partial class Livro
    {
        public int IdLivro { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdLivraria { get; set; }
        public int? IdAutor { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public DateTime DataPublicacao { get; set; }
        public decimal Preco { get; set; }

        public virtual Autor IdAutorNavigation { get; set; }
        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Livraria IdLivrariaNavigation { get; set; }
    }
}
