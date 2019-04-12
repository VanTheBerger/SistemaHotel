using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHotel.Models
{
    public class CadastroViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}
