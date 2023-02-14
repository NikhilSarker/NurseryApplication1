namespace NurseryApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nurserymentrees : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nurserymen",
                c => new
                    {
                        NurserymanId = c.Int(nullable: false, identity: true),
                        NurserymanFirstName = c.String(),
                        NurserymanLastName = c.String(),
                    })
                .PrimaryKey(t => t.NurserymanId);
            
            CreateTable(
                "dbo.NurserymanTrees",
                c => new
                    {
                        Nurseryman_NurserymanId = c.Int(nullable: false),
                        Tree_TreeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Nurseryman_NurserymanId, t.Tree_TreeId })
                .ForeignKey("dbo.Nurserymen", t => t.Nurseryman_NurserymanId, cascadeDelete: true)
                .ForeignKey("dbo.Trees", t => t.Tree_TreeId, cascadeDelete: true)
                .Index(t => t.Nurseryman_NurserymanId)
                .Index(t => t.Tree_TreeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NurserymanTrees", "Tree_TreeId", "dbo.Trees");
            DropForeignKey("dbo.NurserymanTrees", "Nurseryman_NurserymanId", "dbo.Nurserymen");
            DropIndex("dbo.NurserymanTrees", new[] { "Tree_TreeId" });
            DropIndex("dbo.NurserymanTrees", new[] { "Nurseryman_NurserymanId" });
            DropTable("dbo.NurserymanTrees");
            DropTable("dbo.Nurserymen");
        }
    }
}
