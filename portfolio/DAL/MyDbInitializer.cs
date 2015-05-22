using System;
using System.Data.Entity;
using portfolio.Models;

namespace portfolio.DAL
{
	public class MyDbInitializer : CreateDatabaseIfNotExists<MyDbContext>
	{
		protected override void Seed(MyDbContext context)
		{
			//context.Players.Add(new Player {});
			base.Seed(context);
		}
	}
}

