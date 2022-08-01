namespace Zoopark.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Image = c.Binary(),
                        IdFamily = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Families", t => t.IdFamily, cascadeDelete: true)
                .Index(t => t.IdFamily);
            
            CreateTable(
                "dbo.Families",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FamilyName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        IdType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EventTypes", t => t.IdType, cascadeDelete: true)
                .Index(t => t.IdType);
            
            CreateTable(
                "dbo.EventTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SoldTickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        IdTicket = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tickets", t => t.IdTicket, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.IdUser, cascadeDelete: true)
                .Index(t => t.IdUser)
                .Index(t => t.IdTicket);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TicketType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SoldTickets", "IdUser", "dbo.Users");
            DropForeignKey("dbo.SoldTickets", "IdTicket", "dbo.Tickets");
            DropForeignKey("dbo.Events", "IdType", "dbo.EventTypes");
            DropForeignKey("dbo.Animals", "IdFamily", "dbo.Families");
            DropIndex("dbo.SoldTickets", new[] { "IdTicket" });
            DropIndex("dbo.SoldTickets", new[] { "IdUser" });
            DropIndex("dbo.Events", new[] { "IdType" });
            DropIndex("dbo.Animals", new[] { "IdFamily" });
            DropTable("dbo.Users");
            DropTable("dbo.Tickets");
            DropTable("dbo.SoldTickets");
            DropTable("dbo.EventTypes");
            DropTable("dbo.Events");
            DropTable("dbo.Families");
            DropTable("dbo.Animals");
        }
    }
}
