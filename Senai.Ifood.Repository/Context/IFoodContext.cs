using Microsoft.EntityFrameworkCore;

namespace Senai.Ifood.Repository.Context
{
    public class IFoodContext : DbContext
    {
        public DbSet<> MyProperty { get; set; }
    }
}