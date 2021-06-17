using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Peoples_WebApi_Manha.Domains
{
    public class FuncionarioDomain
    {
        public int idFuncionario { get; set; }

        [Required(ErrorMessage = "O nome do funcionário é obrigatório!")]
        public string nome { get; set; }

        [Required(ErrorMessage ="O sobrenome do funcionário é obrigatório!")]
        [StringLength(10, MinimumLength = 5, ErrorMessage ="o sobrenome do funcionário deve conter de 5 a 10 caracteres")]
        public string sobrenome { get; set; }

        [Required(ErrorMessage = "Informe a data de nascimento do funcionário")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}
