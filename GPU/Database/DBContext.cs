using Entities;
using Microsoft.EntityFrameworkCore;


namespace Database
{
	public class DBContext : DbContext
	{
		public DBContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Manufacturer> Manufacturers { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<User> Users { get; set; }
	}
}