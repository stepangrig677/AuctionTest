namespace IdentityTour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Participate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Participates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(),
                        LotID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Participates");
        }
    }
}
