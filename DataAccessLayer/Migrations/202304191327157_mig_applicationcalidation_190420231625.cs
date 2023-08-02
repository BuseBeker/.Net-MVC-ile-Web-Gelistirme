namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_applicationcalidation_190420231625 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Applications", "Name", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Applications", "Surname", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Applications", "Project_name", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Applications", "Description", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Applications", "ProjectType", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Applications", "ProjectType", c => c.String(maxLength: 500));
            AlterColumn("dbo.Applications", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.Applications", "Project_name", c => c.String(maxLength: 500));
            AlterColumn("dbo.Applications", "Surname", c => c.String(maxLength: 500));
            AlterColumn("dbo.Applications", "Name", c => c.String(maxLength: 500));
        }
    }
}
