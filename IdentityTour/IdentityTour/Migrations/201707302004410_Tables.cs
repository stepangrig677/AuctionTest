namespace IdentityTour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bettings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(),
                        LotID = c.Int(),
                        Created = c.DateTime(),
                        Amount = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ParrentID = c.Int(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Lots",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryID = c.Int(),
                        UserID = c.Int(),
                        Created = c.DateTime(),
                        StartTime = c.DateTime(),
                        EndTime = c.DateTime(),
                        StartPrice = c.Decimal(precision: 18, scale: 2),
                        EndPrice = c.Decimal(precision: 18, scale: 2),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Tests");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OperationTime = c.DateTime(),
                        IpAddress = c.String(),
                        Operands = c.String(),
                        Result = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Lots");
            DropTable("dbo.Categories");
            DropTable("dbo.Bettings");
        }
    }
}
