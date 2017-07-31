namespace IdentityTour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLot : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lots", "Name", c => c.String());
            AddColumn("dbo.Lots", "Description", c => c.String());
            AddColumn("dbo.Lots", "Images", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lots", "Images");
            DropColumn("dbo.Lots", "Description");
            DropColumn("dbo.Lots", "Name");
        }
    }
}
