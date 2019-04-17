using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHotel.Models
{
    public class LoginBD
    {
        public string Id { get; set; }



        [Required(ErrorMessage ="Informe o e-mail do usuário!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="O e-mail informado é inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Informe a senha do usuário!")]
        public string Senha { get; set; }

        
    }
}
