using Microsoft.AspNet.Identity.EntityFramework;

namespace portfolio.Models
{
	public class ApplicationUser : IdentityUser {}
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext() : base("DefaultConnection"){}
	}
}