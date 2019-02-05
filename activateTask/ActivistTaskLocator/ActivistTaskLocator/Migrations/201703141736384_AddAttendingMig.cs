namespace ActivistTaskLocator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendingMig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Activities", "Organizer", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Activities", "Organizer", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
