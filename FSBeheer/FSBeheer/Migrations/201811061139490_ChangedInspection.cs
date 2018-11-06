namespace FSBeheer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedInspection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Inspections", "startTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Inspections", "startTime");
        }
    }
}
