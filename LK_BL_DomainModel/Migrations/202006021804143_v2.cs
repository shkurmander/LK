namespace LK.BL.DomainModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AbonentAccounts", newName: "AccountAbonents");
            DropPrimaryKey("dbo.AccountAbonents");
            AlterColumn("dbo.Accounts", "Number", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.AccountAbonents", new[] { "Account_id", "Abonent_id" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.AccountAbonents");
            AlterColumn("dbo.Accounts", "Number", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.AccountAbonents", new[] { "Abonent_id", "Account_id" });
            RenameTable(name: "dbo.AccountAbonents", newName: "AbonentAccounts");
        }
    }
}
