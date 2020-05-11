namespace LK.BL.DomainModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbonentTraffics",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Ammount = c.Long(nullable: false),
                        Type_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TrafficTypes", t => t.Type_id)
                .Index(t => t.Type_id);
            
            CreateTable(
                "dbo.TrafficTypes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Pass = c.String(),
                        Number = c.Int(nullable: false),
                        MyProperty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Abonents",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        Patronimyc = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        EMail = c.String(),
                        Passport = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Tariffs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Bandwidth = c.Int(nullable: false),
                        Measure = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AbonentTraffics", "Type_id", "dbo.TrafficTypes");
            DropIndex("dbo.AbonentTraffics", new[] { "Type_id" });
            DropTable("dbo.Tariffs");
            DropTable("dbo.Abonents");
            DropTable("dbo.Accounts");
            DropTable("dbo.TrafficTypes");
            DropTable("dbo.AbonentTraffics");
        }
    }
}
