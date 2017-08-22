namespace ContosoData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyOnCourses : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Departments_Id", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "Departments_Id" });
            DropColumn("dbo.Courses", "DepartmentId");
            RenameColumn(table: "dbo.Courses", name: "Departments_Id", newName: "DepartmentId");
            AlterColumn("dbo.Courses", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "DepartmentId");
            AddForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "DepartmentId" });
            AlterColumn("dbo.Courses", "DepartmentId", c => c.Int());
            RenameColumn(table: "dbo.Courses", name: "DepartmentId", newName: "Departments_Id");
            AddColumn("dbo.Courses", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "Departments_Id");
            AddForeignKey("dbo.Courses", "Departments_Id", "dbo.Departments", "Id");
        }
    }
}
