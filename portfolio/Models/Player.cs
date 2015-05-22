using System;
using System.Data.Entity;

namespace portfolio.Models
{
	public class Player
	{
		public int    ID {get;set;}
		public string Name {get;set;}
		public int    Health {get; set;}
		public int    InventoryId { get; set; }
	}
}

