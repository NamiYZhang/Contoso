namespace ContosoData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationsOnInstructorAndPeople : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departments", "InstructorId", "dbo.Instructors");
            DropForeignKey("dbo.OfficeAssignments", "Id", "dbo.Instructors");
            DropPrimaryKey("dbo.Instructors");
            AlterColumn("dbo.Instructors", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Instructors", "Id");
            CreateIndex("dbo.Instructors", "Id");
            AddForeignKey("dbo.Instructors", "Id", "dbo.People", "Id");
            AddForeignKey("dbo.Departments", "InstructorId", "dbo.Instructors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OfficeAssignments", "Id", "dbo.Instructors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OfficeAssignments", "Id", "dbo.Instructors");
            DropForeignKey("dbo.Departments", "InstructorId", "dbo.Instructors");
            DropForeignKey("dbo.Instructors", "Id", "dbo.People");
            DropIndex("dbo.Instructors", new[] { "Id" });
            DropPrimaryKey("dbo.Instructors");
            AlterColumn("dbo.Instructors", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Instructors", "Id");
            AddForeignKey("dbo.OfficeAssignments", "Id", "dbo.Instructors", "Id");
            AddForeignKey("dbo.Departments", "InstructorId", "dbo.Instructors", "Id", cascadeDelete: true);
        }
    }
}
