using Microsoft.EntityFrameworkCore;
using Senai.Ifood.Domain.Entities;

namespace Senai.Ifood.Repository.Context
{
    public class IFoodContext : DbContext
    {
        public IFoodContext(DbContextOptions<IFoodContext> options) : base(options){}
        public DbSet<ClienteDomain> Clientes { get; set; }
        public DbSet<EspecialidadeDomain> Especialidades { get; set; }
        public DbSet<PermissaoDomain> Permissoes { get; set; }
        public DbSet<ProdutoDomain> Produtos { get; set; }
        public DbSet<RestauranteDomain> Restaurates { get; set; }
        public DbSet<UsuarioDomain> Usuarios { get; set; }
        public DbSet<UsuarioPermissaoDomain> UsuariosPermissoes { get; set; }
    }
}