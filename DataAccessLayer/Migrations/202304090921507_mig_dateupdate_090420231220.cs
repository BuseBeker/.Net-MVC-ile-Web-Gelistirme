namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_dateupdate_090420231220 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Applications", "StartDate");
            DropColumn("dbo.Applications", "EndDate");
            DropColumn("dbo.Applications", "RecordDate");
            DropColumn("dbo.UserRoles", "RecordDate");
            DropColumn("dbo.Users", "RecordDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "RecordDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserRoles", "RecordDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Applications", "RecordDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Applications", "EndDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Applications", "StartDate", c => c.DateTime(nullable: false));
        }
    }
}
