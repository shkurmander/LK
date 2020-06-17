namespace LK.BL.DomainModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relationships_change_1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AccountAbonents", "Account_id", "dbo.Accounts");
            DropForeignKey("dbo.AccountAbonents", "Abonent_id", "dbo.Abonents");
            DropForeignKey("dbo.Tariffs", "Account_id", "dbo.Accounts");
            DropIndex("dbo.Tariffs", new[] { "Account_id" });
            DropIndex("dbo.AccountAbonents", new[] { "Account_id" });
            DropIndex("dbo.AccountAbonents", new[] { "Abonent_id" });
            AddColumn("dbo.Accounts", "AccAbonent_id", c => c.Int());
            AddColumn("dbo.Accounts", "AccTariff_id", c => c.Int());
            CreateIndex("dbo.Accounts", "AccAbonent_id");
            CreateIndex("dbo.Accounts", "AccTariff_id");
            AddForeignKey("dbo.Accounts", "AccAbonent_id", "dbo.Abonents", "id");
            AddForeignKey("dbo.Accounts", "AccTariff_id", "dbo.Tariffs", "id");
            DropColumn("dbo.Tariffs", "Account_id");
            DropTable("dbo.AccountAbonents");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AccountAbonents",
                c => new
                    {
                        Account_id = c.Int(nullable: false),
                        Abonent_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Account_id, t.Abonent_id });
            
            AddColumn("dbo.Tariffs", "Account_id", c => c.Int());
            DropForeignKey("dbo.Accounts", "AccTariff_id", "dbo.Tariffs");
            DropForeignKey("dbo.Accounts", "AccAbonent_id", "dbo.Abonents");
            DropIndex("dbo.Accounts", new[] { "AccTariff_id" });
            DropIndex("dbo.Accounts", new[] { "AccAbonent_id" });
            DropColumn("dbo.Accounts", "AccTariff_id");
            DropColumn("dbo.Accounts", "AccAbonent_id");
            CreateIndex("dbo.AccountAbonents", "Abonent_id");
            CreateIndex("dbo.AccountAbonents", "Account_id");
            CreateIndex("dbo.Tariffs", "Account_id");
            AddForeignKey("dbo.Tariffs", "Account_id", "dbo.Accounts", "id");
            AddForeignKey("dbo.AccountAbonents", "Abonent_id", "dbo.Abonents", "id", cascadeDelete: true);
            AddForeignKey("dbo.AccountAbonents", "Account_id", "dbo.Accounts", "id", cascadeDelete: true);
        }
    }
}
