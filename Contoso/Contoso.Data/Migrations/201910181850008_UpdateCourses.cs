namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCourses : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "DepartmentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "DepartmentId", c => c.Int(nullable: false));
        }
    }
}
