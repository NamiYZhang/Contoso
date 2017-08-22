namespace ContosoData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createAll : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Credit = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        Departments_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Departments_Id)
                .Index(t => t.Departments_Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Budget = c.Double(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        InstructorId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Instructors", t => t.InstructorId, cascadeDelete: true)
                .Index(t => t.InstructorId);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        Grade = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        Courses_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Courses_Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.Courses_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnrollmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OfficeAssignments",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Location = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Instructors", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        MiddleName = c.String(),
                        Age = c.Int(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        UnitOrApartmentNumber = c.Int(nullable: false),
                        City = c.String(),
                        State = c.String(),
                        Zipcode = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        Password = c.String(),
                        Salt = c.String(),
                        isLocked = c.Boolean(nullable: false),
                        LastLockedDateTime = c.DateTime(nullable: false),
                        FailedAttempts = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        Description = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OfficeAssignments", "Id", "dbo.Instructors");
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Enrollments", "Courses_Id", "dbo.Courses");
            DropForeignKey("dbo.Departments", "InstructorId", "dbo.Instructors");
            DropForeignKey("dbo.Courses", "Departments_Id", "dbo.Departments");
            DropIndex("dbo.OfficeAssignments", new[] { "Id" });
            DropIndex("dbo.Enrollments", new[] { "Courses_Id" });
            DropIndex("dbo.Enrollments", new[] { "StudentId" });
            DropIndex("dbo.Departments", new[] { "InstructorId" });
            DropIndex("dbo.Courses", new[] { "Departments_Id" });
            DropTable("dbo.Roles");
            DropTable("dbo.People");
            DropTable("dbo.OfficeAssignments");
            DropTable("dbo.Students");
            DropTable("dbo.Enrollments");
            DropTable("dbo.Instructors");
            DropTable("dbo.Departments");
            DropTable("dbo.Courses");
        }
    }
}
