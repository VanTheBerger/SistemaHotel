using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSistemaHotel.ViewModel
{
    public class LoginViewModel : PageModel
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
    }
}
