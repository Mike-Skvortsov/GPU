using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Database
{
	public class DBContext : DbContext
	{
		public DBContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Chipset> Chipsets { get; set; }
		public DbSet<Details> Details { get; set; }
		public DbSet<FromFactor> FromFactors { get; set; }
		public DbSet<Memory> Memories { get; set; }
		public DbSet<Ports> Ports { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Specifications> Specifications { get; set; }
		public DbSet<Supported3DAPIs> Supported3DAPIs { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>()
				.HasOne(p => p.Specifications)
				.WithOne(s => s.Products)
				.HasForeignKey<Specifications>(s => s.ProductId);
			modelBuilder.Entity<Memory>()
				.HasMany(m => m.Specifications)
				.WithOne(s => s.Memory)
				.HasForeignKey(s => s.MemoryId);
			modelBuilder.Entity<Chipset>()
				.HasMany(m => m.Specifications)
				.WithOne(s => s.Chipset)
				.HasForeignKey(s => s.ChipsetId);
			modelBuilder.Entity<Details>()
				.HasMany(m => m.Specifications)
				.WithOne(s => s.Details)
				.HasForeignKey(s => s.DetailsId);
			modelBuilder.Entity<FromFactor>()
				.HasMany(m => m.Specifications)
				.WithOne(s => s.FromFactor)
				.HasForeignKey(s => s.FromFactorId);
			modelBuilder.Entity<Ports>()
				.HasMany(m => m.Specifications)
				.WithOne(s => s.Ports)
				.HasForeignKey(s => s.PortsId);
			modelBuilder.Entity<Supported3DAPIs>()
				.HasMany(m => m.Specifications)
				.WithOne(s => s.Supported3DAPIs)
				.HasForeignKey(s => s.Supported3DAPIsId);
		}
	}
}