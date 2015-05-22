using System;
using System.Data.Entity;
using portfolio.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace portfolio.DAL
{
	public class MyDbContext : DbContext
	{
		public MyDbContext () : base("MyDbContextConnectionString")
		{
			Database.SetInitializer<MyDbContext>(new MyDbInitializer());
		}

		public DbSet<Player> Players {get;set;}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}