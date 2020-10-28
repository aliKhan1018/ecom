namespace ecommerceSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BrandSubCategories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BrandSubCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BrandID = c.Int(nullable: false),
                        SubCategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Brands", t => t.BrandID, cascadeDelete: true)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryID, cascadeDelete: true)
                .Index(t => t.BrandID)
                .Index(t => t.SubCategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BrandSubCategories", "SubCategoryID", "dbo.SubCategories");
            DropForeignKey("dbo.BrandSubCategories", "BrandID", "dbo.Brands");
            DropIndex("dbo.BrandSubCategories", new[] { "SubCategoryID" });
            DropIndex("dbo.BrandSubCategories", new[] { "BrandID" });
            DropTable("dbo.BrandSubCategories");
        }
    }
}
