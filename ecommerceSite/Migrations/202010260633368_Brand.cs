namespace ecommerceSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Brand : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Brands", "SubCategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Brands", "SubCategoryID");
            AddForeignKey("dbo.Brands", "SubCategoryID", "dbo.SubCategories", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Brands", "SubCategoryID", "dbo.SubCategories");
            DropIndex("dbo.Brands", new[] { "SubCategoryID" });
            DropColumn("dbo.Brands", "SubCategoryID");
        }
    }
}
