namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_projectstatusint_dropfile_130420231210 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Applications", "ProjectStatus", c => c.Int(nullable: false));
            DropColumn("dbo.Applications", "File");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Applications", "File", c => c.String());
            AlterColumn("dbo.Applications", "ProjectStatus", c => c.Boolean(nullable: false));
        }
    }
}
