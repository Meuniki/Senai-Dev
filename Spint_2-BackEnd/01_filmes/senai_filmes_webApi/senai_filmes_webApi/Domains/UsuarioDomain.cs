using System.ComponentModel.DataAnnotations;

namespace Senai_Peoples_WebApi_Manha.Domains
{
    /// <summary>
    /// Classe que representa a entidade (tabela) Usuário
    /// </summary>
    public class UsuarioDomain
    {
        
        public int idUsuario { get; set; }

        // Define que o campo é obrigatório
        [Required(ErrorMessage = "Imforme o e-mail")]

        public string email { get; set; }
        
        // Define que o campo é obrigatório, com no mínomo 3 e no máximo 20 caracteres
        [Required(ErrorMessage = "Imforme a senha")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "O campo senha precisa ter no mínimo 3 e no máximo 20 caracteres")]
        public string senha { get; set; }

        public string permissao { get; set; }
    }
}
