namespace OpenQbit.Accounts.DAL.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBinit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentAccountId = c.Int(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transaction",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransactionTime = c.DateTime(nullable: false),
                        Description = c.String(),
                        ReferenceTag = c.String(),
                        TransactionTemplateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TransactionTemplate", t => t.TransactionTemplateId, cascadeDelete: true)
                .Index(t => t.TransactionTemplateId);
            
            CreateTable(
                "dbo.TransactionTemplate",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DocumentTypeId = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DocumentType", t => t.DocumentTypeId, cascadeDelete: true)
                .Index(t => t.DocumentTypeId);
            
            CreateTable(
                "dbo.DocumentType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.TransactionDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        CrDb = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Account", t => t.AccountId, cascadeDelete: true)
                .Index(t => t.AccountId);
            
            CreateTable(
                "dbo.TransactionTemplateDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        CrDb = c.String(),
                        AmountExpression = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Account", t => t.AccountId, cascadeDelete: true)
                .Index(t => t.AccountId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionTemplateDetail", "AccountId", "dbo.Account");
            DropForeignKey("dbo.TransactionDetail", "AccountId", "dbo.Account");
            DropForeignKey("dbo.Transaction", "TransactionTemplateId", "dbo.TransactionTemplate");
            DropForeignKey("dbo.TransactionTemplate", "DocumentTypeId", "dbo.DocumentType");
            DropForeignKey("dbo.DocumentType", "CustomerId", "dbo.Customer");
            DropIndex("dbo.TransactionTemplateDetail", new[] { "AccountId" });
            DropIndex("dbo.TransactionDetail", new[] { "AccountId" });
            DropIndex("dbo.DocumentType", new[] { "CustomerId" });
            DropIndex("dbo.TransactionTemplate", new[] { "DocumentTypeId" });
            DropIndex("dbo.Transaction", new[] { "TransactionTemplateId" });
            DropTable("dbo.TransactionTemplateDetail");
            DropTable("dbo.TransactionDetail");
            DropTable("dbo.DocumentType");
            DropTable("dbo.TransactionTemplate");
            DropTable("dbo.Transaction");
            DropTable("dbo.Customer");
            DropTable("dbo.Account");
        }
    }
}
