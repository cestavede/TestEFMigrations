namespace Data.EFProvider.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEventLocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CalendarEvents", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CalendarEvents", "Location");
        }
    }
}
