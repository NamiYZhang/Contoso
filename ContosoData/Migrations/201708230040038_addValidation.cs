namespace ContosoData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Title", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.OfficeAssignments", "Location", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OfficeAssignments", "Location", c => c.String());
            AlterColumn("dbo.Courses", "Title", c => c.String());
        }
    }
}
