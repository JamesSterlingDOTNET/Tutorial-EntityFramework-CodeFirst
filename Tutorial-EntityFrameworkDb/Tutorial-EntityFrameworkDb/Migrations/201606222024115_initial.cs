namespace Tutorial_EntityFrameworkDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bank",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Card",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Pin = c.Int(nullable: false),
                        BankId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bank", t => t.BankId, cascadeDelete: true)
                .ForeignKey("dbo.Customer", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.BankId);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Card", "Id", "dbo.Customer");
            DropForeignKey("dbo.Card", "BankId", "dbo.Bank");
            DropIndex("dbo.Card", new[] { "BankId" });
            DropIndex("dbo.Card", new[] { "Id" });
            DropTable("dbo.Customer");
            DropTable("dbo.Card");
            DropTable("dbo.Bank");
        }
    }
}
