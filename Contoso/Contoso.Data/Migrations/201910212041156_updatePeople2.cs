namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePeople2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "FailedAttempts", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "FailedAttempts", c => c.Int(nullable: false));
        }
    }
}
