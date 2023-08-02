namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_applicationtableupdate_090420231125 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applications", "File", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Applications", "File");
        }
    }
}
