namespace IdentityTour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserId : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bettings", "UserID", c => c.String());
            AlterColumn("dbo.Lots", "UserID", c => c.String());
            AlterColumn("dbo.Participates", "UserID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Participates", "UserID", c => c.Int());
            AlterColumn("dbo.Lots", "UserID", c => c.Int());
            AlterColumn("dbo.Bettings", "UserID", c => c.Int());
        }
    }
}
