using Microsoft.EntityFrameworkCore;
using WebApiFuncionariosCRUD.Models;

namespace WebApiFuncionariosCRUD.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
