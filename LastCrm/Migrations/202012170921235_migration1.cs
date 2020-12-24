namespace LastCrm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Check1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        SpecialistId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Specialists", t => t.SpecialistId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.SpecialistId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sellings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Check1Id = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Check1", t => t.Check1Id, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.Check1Id)
                .Index(t => t.ServiceId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Specialists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Check1", "SpecialistId", "dbo.Specialists");
            DropForeignKey("dbo.Sellings", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.Sellings", "Check1Id", "dbo.Check1");
            DropForeignKey("dbo.Check1", "ClientId", "dbo.Clients");
            DropIndex("dbo.Sellings", new[] { "ServiceId" });
            DropIndex("dbo.Sellings", new[] { "Check1Id" });
            DropIndex("dbo.Check1", new[] { "SpecialistId" });
            DropIndex("dbo.Check1", new[] { "ClientId" });
            DropTable("dbo.Specialists");
            DropTable("dbo.Services");
            DropTable("dbo.Sellings");
            DropTable("dbo.Clients");
            DropTable("dbo.Check1");
        }
    }
}
