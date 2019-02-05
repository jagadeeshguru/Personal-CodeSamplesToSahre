namespace ActivistTaskLocator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Activity = c.String(),
                        Date = c.DateTime(nullable: false),
                        Address = c.String(),
                        Organizer = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Activities");
        }
    }
}
