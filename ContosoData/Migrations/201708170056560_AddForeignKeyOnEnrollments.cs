namespace ContosoData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyOnEnrollments : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enrollments", "Courses_Id", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "Courses_Id" });
            DropColumn("dbo.Enrollments", "CourseId");
            RenameColumn(table: "dbo.Enrollments", name: "Courses_Id", newName: "CourseId");
            AlterColumn("dbo.Enrollments", "CourseId", c => c.Int(nullable: false));
            CreateIndex("dbo.Enrollments", "CourseId");
            AddForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "CourseId" });
            AlterColumn("dbo.Enrollments", "CourseId", c => c.Int());
            RenameColumn(table: "dbo.Enrollments", name: "CourseId", newName: "Courses_Id");
            AddColumn("dbo.Enrollments", "CourseId", c => c.Int(nullable: false));
            CreateIndex("dbo.Enrollments", "Courses_Id");
            AddForeignKey("dbo.Enrollments", "Courses_Id", "dbo.Courses", "Id");
        }
    }
}
