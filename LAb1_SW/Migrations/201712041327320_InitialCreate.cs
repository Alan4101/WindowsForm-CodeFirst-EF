namespace LAb1_SW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        Photo = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SageBooks",
                c => new
                    {
                        Sage_ID = c.Int(nullable: false),
                        Books_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sage_ID, t.Books_Id })
                .ForeignKey("dbo.Sages", t => t.Sage_ID, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Books_Id, cascadeDelete: true)
                .Index(t => t.Sage_ID)
                .Index(t => t.Books_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SageBooks", "Books_Id", "dbo.Books");
            DropForeignKey("dbo.SageBooks", "Sage_ID", "dbo.Sages");
            DropIndex("dbo.SageBooks", new[] { "Books_Id" });
            DropIndex("dbo.SageBooks", new[] { "Sage_ID" });
            DropTable("dbo.SageBooks");
            DropTable("dbo.Sages");
            DropTable("dbo.Books");
        }
    }
}
