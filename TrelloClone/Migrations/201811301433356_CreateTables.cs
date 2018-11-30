namespace TrelloClone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        ApplicationUser_Id = c.String(),
                        ApplicationUser_Id1 = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id1)
                .Index(t => t.ApplicationUser_Id1);
            
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        ListID = c.Int(nullable: false),
                        Lists_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Lists", t => t.Lists_ID)
                .Index(t => t.Lists_ID);
            
            CreateTable(
                "dbo.Lists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        BoardID = c.Int(nullable: false),
                        Boards_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Boards", t => t.Boards_ID)
                .Index(t => t.Boards_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cards", "Lists_ID", "dbo.Lists");
            DropForeignKey("dbo.Lists", "Boards_ID", "dbo.Boards");
            DropForeignKey("dbo.Boards", "ApplicationUser_Id1", "dbo.AspNetUsers");
            DropIndex("dbo.Lists", new[] { "Boards_ID" });
            DropIndex("dbo.Cards", new[] { "Lists_ID" });
            DropIndex("dbo.Boards", new[] { "ApplicationUser_Id1" });
            DropTable("dbo.Lists");
            DropTable("dbo.Cards");
            DropTable("dbo.Boards");
        }
    }
}
