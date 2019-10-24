namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialPeopleAndRoles : DbMigration
    {
        public override void Up()
        {
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
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        DateofBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        Phone = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        UnitOrApartmentNumber = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        Password = c.String(),
                        Salt = c.String(),
                        IsLocked = c.String(),
                        LastLockedDateTime = c.String(),
                        FailedAttempts = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PeopleRoles",
                c => new
                    {
                        People_Id = c.Int(nullable: false),
                        Roles_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.People_Id, t.Roles_Id })
                .ForeignKey("dbo.People", t => t.People_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Roles_Id, cascadeDelete: true)
                .Index(t => t.People_Id)
                .Index(t => t.Roles_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PeopleRoles", "Roles_Id", "dbo.Roles");
            DropForeignKey("dbo.PeopleRoles", "People_Id", "dbo.People");
            DropIndex("dbo.PeopleRoles", new[] { "Roles_Id" });
            DropIndex("dbo.PeopleRoles", new[] { "People_Id" });
            DropTable("dbo.PeopleRoles");
            DropTable("dbo.People");
            DropTable("dbo.Roles");
        }
    }
}
