namespace ContosoData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationsOnStudent : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Students");
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Students", "Id");
            CreateIndex("dbo.Students", "Id");
            AddForeignKey("dbo.Students", "Id", "dbo.People", "Id");
            AddForeignKey("dbo.Enrollments", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "Id", "dbo.People");
            DropIndex("dbo.Students", new[] { "Id" });
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Students", "Id");
            AddForeignKey("dbo.Enrollments", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
        }
    }
}
