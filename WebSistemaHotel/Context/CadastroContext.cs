using Microsoft.EntityFrameworkCore;
using WebSistemaHotel.Models;
namespace WebSistemaHotel.Context
{
    public class CadastroContext : DbContext
    {
        public CadastroContext(DbContextOptions<CadastroContext> options) : base(options)
        {

        }

        public DbSet<CadastroModel> Cadastros { get; set; }
    }
}
