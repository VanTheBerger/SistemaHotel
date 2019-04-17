using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSistemaHotel.Models
{
    public class LoginModel : PageModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "E-mail é obrigatorio")]
        [DataType(DataType.Text)]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatorio")]
        [DataType(DataType.Text)]
        public string Senha { get; set; }
    }
}
