namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_dropstatus_120420230900 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserRoles", "UserRoleStatus");
            DropColumn("dbo.Roles", "RoleStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "RoleStatus", c => c.Boolean(nullable: false));
            AddColumn("dbo.UserRoles", "UserRoleStatus", c => c.Boolean(nullable: false));
        }
    }
}
