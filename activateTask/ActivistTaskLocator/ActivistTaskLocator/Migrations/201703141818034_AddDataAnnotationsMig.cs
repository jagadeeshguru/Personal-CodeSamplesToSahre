namespace ActivistTaskLocator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotationsMig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Activities", "Activity", c => c.String(nullable: false));
            AlterColumn("dbo.Activities", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Activities", "Organizer", c => c.String(nullable: false));
            AlterColumn("dbo.Activities", "Attending", c => c.String(maxLength: 3));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Activities", "Attending", c => c.String());
            AlterColumn("dbo.Activities", "Organizer", c => c.String());
            AlterColumn("dbo.Activities", "Address", c => c.String());
            AlterColumn("dbo.Activities", "Activity", c => c.String());
        }
    }
}
