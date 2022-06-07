using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RunIO.App.ViewModels;

namespace RunIO.App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RunIO.App.ViewModels.ProdutoViewModel>? ProdutoViewModel { get; set; }
        public DbSet<RunIO.App.ViewModels.EnderecoViewModel>? EnderecoViewModel { get; set; }
        
    }
}