namespace Data.EFProvider.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CalendarEvents",
                c => new
                    {
                        CalendarEventId = c.Guid(nullable: false),
                        Start = c.DateTime(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CalendarEventId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CalendarEvents");
        }
    }
}
