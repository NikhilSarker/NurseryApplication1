namespace NurseryApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoriesId = c.Int(nullable: false, identity: true),
                        CategoriesName = c.String(),
                    })
                .PrimaryKey(t => t.CategoriesId);
            
            AddColumn("dbo.Trees", "TreeHeight", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trees", "TreeHeight");
            DropTable("dbo.Categories");
        }
    }
}
