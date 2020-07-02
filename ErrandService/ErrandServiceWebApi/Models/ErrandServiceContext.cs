using Microsoft.EntityFrameworkCore;

namespace DormManagementApi.Models
{
    public class ErrandServiceContext : DbContext
    {
        public ErrandServiceContext(DbContextOptions<ErrandServiceContext> options)
          : base(options)
        {
            this.Database.EnsureCreated(); //自动建库建表
        }

        public DbSet<OrderOperation> OrderOperation { get; set; }

        public DbSet<Order> Orders { get; set; }
		public DbSet<Order> PublicOrders { get; set; }
	}
}

