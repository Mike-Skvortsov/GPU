using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
	internal class DataBaseContextFactory: IDesignTimeDbContextFactory<DBContext>
	{
		public DBContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<DBContext>();
			optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ForVlados;Integrated Security=True");
			return new DBContext(optionsBuilder.Options);
		}
	}
}
