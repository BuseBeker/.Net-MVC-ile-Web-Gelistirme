namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_tablolarastatusekle_100420231440 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applications", "ApplicationStatus", c => c.Boolean(nullable: false));
            AddColumn("dbo.Roles", "RoleStatus", c => c.Boolean(nullable: false));
            AddColumn("dbo.UserRoles", "UserRoleStatus", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "UserStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "UserStatus");
            DropColumn("dbo.UserRoles", "UserRoleStatus");
            DropColumn("dbo.Roles", "RoleStatus");
            DropColumn("dbo.Applications", "ApplicationStatus");
        }
    }
}
