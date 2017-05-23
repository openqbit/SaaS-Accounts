namespace OpenQbit.Accounts.DAL.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccoutnsModelCusIDadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Account", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Account", "CustomerId");
            AddForeignKey("dbo.Account", "CustomerId", "dbo.Customer", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Account", "CustomerId", "dbo.Customer");
            DropIndex("dbo.Account", new[] { "CustomerId" });
            DropColumn("dbo.Account", "CustomerId");
        }
    }
}
