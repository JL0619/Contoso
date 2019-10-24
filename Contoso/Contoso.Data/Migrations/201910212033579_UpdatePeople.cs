namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePeople : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "DateofBirth", c => c.DateTime());
            AlterColumn("dbo.People", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.People", "UpdatedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.People", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.People", "DateofBirth", c => c.DateTime(nullable: false));
        }
    }
}
