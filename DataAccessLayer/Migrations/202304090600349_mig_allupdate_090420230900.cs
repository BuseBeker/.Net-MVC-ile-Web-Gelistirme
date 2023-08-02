namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_allupdate_090420230900 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Surname", c => c.String(maxLength: 500));
            AlterColumn("dbo.Roles", "RoleName", c => c.String(maxLength: 500));
            AlterColumn("dbo.Roles", "Description", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Roles", "Description", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Roles", "RoleName", c => c.String(maxLength: 1000));
            DropColumn("dbo.Users", "Surname");
        }
    }
}
