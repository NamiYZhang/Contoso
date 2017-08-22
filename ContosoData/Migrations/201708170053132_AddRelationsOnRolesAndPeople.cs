namespace ContosoData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationsOnRolesAndPeople : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RolesPersons",
                c => new
                    {
                        Roles_Id = c.Int(nullable: false),
                        Person_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Roles_Id, t.Person_Id })
                .ForeignKey("dbo.Roles", t => t.Roles_Id, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.Person_Id, cascadeDelete: true)
                .Index(t => t.Roles_Id)
                .Index(t => t.Person_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolesPersons", "Person_Id", "dbo.People");
            DropForeignKey("dbo.RolesPersons", "Roles_Id", "dbo.Roles");
            DropIndex("dbo.RolesPersons", new[] { "Person_Id" });
            DropIndex("dbo.RolesPersons", new[] { "Roles_Id" });
            DropTable("dbo.RolesPersons");
        }
    }
}
