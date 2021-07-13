using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CzBooks_WebApi.Domains
{
    public partial class Livro
    {
        public int IdLivro { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdLivraria { get; set; }
        public int? IdAutor { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Sinopse { get; set; }

        [Required (ErrorMessage ="Informe a data de publicação")]
        public DateTime DataPublicacao { get; set; }
        [Required]
        public decimal Preco { get; set; }

        public virtual Autor IdAutorNavigation { get; set; }
        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Livraria IdLivrariaNavigation { get; set; }
    }
}
