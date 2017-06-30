namespace OpenQbit.Accounts.DAL.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbInit1 : DbMigration
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
                        CustomerId = c.Int(nullable: false),
                        CustomerSystem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CustomerSystem", t => t.CustomerSystem_Id)
                .Index(t => t.CustomerSystem_Id);
            
            CreateTable(
                "dbo.CustomerSystem",
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
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SystemId = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Document",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CustomerId = c.Int(nullable: false),
                        CustomerSystem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.CustomerSystem", t => t.CustomerSystem_Id)
                .Index(t => t.CustomerId)
                .Index(t => t.CustomerSystem_Id);
            
            CreateTable(
                "dbo.TransactionTemplate",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DocumentId = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Document", t => t.DocumentId, cascadeDelete: true)
                .Index(t => t.DocumentId);
            
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
                "dbo.TransactionDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        TransactionId = c.Int(nullable: false),
                        CrAmount = c.Double(nullable: false),
                        DbAmount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Account", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.Transaction", t => t.TransactionId, cascadeDelete: true)
                .Index(t => t.AccountId)
                .Index(t => t.TransactionId);
            
            CreateTable(
                "dbo.TransactionTemplateDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        CrDb = c.String(),
                        AmountExpression = c.String(),
                        TransactionTemplate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Account", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.TransactionTemplate", t => t.TransactionTemplate_Id)
                .Index(t => t.AccountId)
                .Index(t => t.TransactionTemplate_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Document", "CustomerSystem_Id", "dbo.CustomerSystem");
            DropForeignKey("dbo.TransactionTemplateDetail", "TransactionTemplate_Id", "dbo.TransactionTemplate");
            DropForeignKey("dbo.TransactionTemplateDetail", "AccountId", "dbo.Account");
            DropForeignKey("dbo.Transaction", "TransactionTemplateId", "dbo.TransactionTemplate");
            DropForeignKey("dbo.TransactionDetail", "TransactionId", "dbo.Transaction");
            DropForeignKey("dbo.TransactionDetail", "AccountId", "dbo.Account");
            DropForeignKey("dbo.TransactionTemplate", "DocumentId", "dbo.Document");
            DropForeignKey("dbo.Document", "CustomerId", "dbo.Customer");
            DropForeignKey("dbo.CustomerSystem", "CustomerId", "dbo.Customer");
            DropForeignKey("dbo.Account", "CustomerSystem_Id", "dbo.CustomerSystem");
            DropIndex("dbo.TransactionTemplateDetail", new[] { "TransactionTemplate_Id" });
            DropIndex("dbo.TransactionTemplateDetail", new[] { "AccountId" });
            DropIndex("dbo.TransactionDetail", new[] { "TransactionId" });
            DropIndex("dbo.TransactionDetail", new[] { "AccountId" });
            DropIndex("dbo.Transaction", new[] { "TransactionTemplateId" });
            DropIndex("dbo.TransactionTemplate", new[] { "DocumentId" });
            DropIndex("dbo.Document", new[] { "CustomerSystem_Id" });
            DropIndex("dbo.Document", new[] { "CustomerId" });
            DropIndex("dbo.CustomerSystem", new[] { "CustomerId" });
            DropIndex("dbo.Account", new[] { "CustomerSystem_Id" });
            DropTable("dbo.TransactionTemplateDetail");
            DropTable("dbo.TransactionDetail");
            DropTable("dbo.Transaction");
            DropTable("dbo.TransactionTemplate");
            DropTable("dbo.Document");
            DropTable("dbo.Customer");
            DropTable("dbo.CustomerSystem");
            DropTable("dbo.Account");
        }
    }
}
