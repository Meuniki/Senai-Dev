using System.ComponentModel.DataAnnotations;

namespace senai_filmes_webApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade Generos
    /// </summary>
    public class GeneroDomain
    {
        public int idGenero { get; set; }

        [Required(ErrorMessage = "O nome do gênero é obrigatório!")]
        public string nome { get; set; }
    }
}
