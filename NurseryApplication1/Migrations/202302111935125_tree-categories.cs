namespace NurseryApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class treecategories : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trees", "CategoriesId", c => c.Int(nullable: false));
            CreateIndex("dbo.Trees", "CategoriesId");
            AddForeignKey("dbo.Trees", "CategoriesId", "dbo.Categories", "CategoriesId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trees", "CategoriesId", "dbo.Categories");
            DropIndex("dbo.Trees", new[] { "CategoriesId" });
            DropColumn("dbo.Trees", "CategoriesId");
        }
    }
}
