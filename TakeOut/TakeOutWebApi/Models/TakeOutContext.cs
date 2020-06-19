using Microsoft.EntityFrameworkCore;

namespace DormManagementApi.Models
{
    public class TakeOutContext : DbContext
    {
        public TakeOutContext(DbContextOptions<TakeOutContext> options)
          : base(options)
        {
            this.Database.EnsureCreated(); //自动建库建表
        }

        public DbSet<TakeOutOrder> TakeOutOrders { get; set; }

        public DbSet<Student> Students { get; set; }
    }
}
