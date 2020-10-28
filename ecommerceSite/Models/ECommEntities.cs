using System.Data.Entity;

namespace ecommerceSite.Models
{
	public class ECommEntities : DbContext
	{
		public DbSet<Category> Categories { get; set; }
		public DbSet<SubCategory> SubCategories { get; set; }
		public DbSet<Brand> Brands { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<BrandSubCategory> BrandSubCategories { get; set; }
	}
}