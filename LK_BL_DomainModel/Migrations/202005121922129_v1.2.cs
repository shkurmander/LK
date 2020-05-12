namespace LK.BL.DomainModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v12 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbonentAccounts",
                c => new
                    {
                        Abonent_id = c.Int(nullable: false),
                        Account_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Abonent_id, t.Account_id })
                .ForeignKey("dbo.Abonents", t => t.Abonent_id, cascadeDelete: true)
                .ForeignKey("dbo.Accounts", t => t.Account_id, cascadeDelete: true)
                .Index(t => t.Abonent_id)
                .Index(t => t.Account_id);
            
            AddColumn("dbo.Accounts", "Login", c => c.String());
            AddColumn("dbo.Accounts", "Password", c => c.String());
            AddColumn("dbo.Abonents", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Abonents", "Phone", c => c.String());
            AddColumn("dbo.Tariffs", "Account_id", c => c.Int());
            CreateIndex("dbo.Tariffs", "Account_id");
            AddForeignKey("dbo.Tariffs", "Account_id", "dbo.Accounts", "id");
            DropColumn("dbo.Accounts", "UserName");
            DropColumn("dbo.Accounts", "Pass");
            DropColumn("dbo.Accounts", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Accounts", "MyProperty", c => c.Int(nullable: false));
            AddColumn("dbo.Accounts", "Pass", c => c.String());
            AddColumn("dbo.Accounts", "UserName", c => c.String());
            DropForeignKey("dbo.Tariffs", "Account_id", "dbo.Accounts");
            DropForeignKey("dbo.AbonentAccounts", "Account_id", "dbo.Accounts");
            DropForeignKey("dbo.AbonentAccounts", "Abonent_id", "dbo.Abonents");
            DropIndex("dbo.AbonentAccounts", new[] { "Account_id" });
            DropIndex("dbo.AbonentAccounts", new[] { "Abonent_id" });
            DropIndex("dbo.Tariffs", new[] { "Account_id" });
            DropColumn("dbo.Tariffs", "Account_id");
            DropColumn("dbo.Abonents", "Phone");
            DropColumn("dbo.Abonents", "BirthDate");
            DropColumn("dbo.Accounts", "Password");
            DropColumn("dbo.Accounts", "Login");
            DropTable("dbo.AbonentAccounts");
        }
    }
}
