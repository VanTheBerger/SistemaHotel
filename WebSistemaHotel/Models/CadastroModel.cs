using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSistemaHotel.Models
{
    public class CadastroModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatorio")]
        [DataType(DataType.Text)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "E-mail é obrigatorio")]
        [DataType(DataType.Text)]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo de genero é obrigatorio")]
        [DataType(DataType.Text)]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "O estado é obrigatorio")]
        [DataType(DataType.Text)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "A cidade é obrigatoria")]
        [DataType(DataType.Text)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatorio")]
        [DataType(DataType.Text)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "A senha é obrigatorio")]
        [DataType(DataType.Text)]
        public string Senha { get; set; }
    }
    
}
