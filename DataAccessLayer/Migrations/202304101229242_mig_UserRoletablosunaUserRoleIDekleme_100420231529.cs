namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_UserRoletablosunaUserRoleIDekleme_100420231529 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.UserRoles");
            AddColumn("dbo.UserRoles", "UserRoleID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.UserRoles", "UserRoleID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.UserRoles");
            DropColumn("dbo.UserRoles", "UserRoleID");
            AddPrimaryKey("dbo.UserRoles", new[] { "UserID", "RoleID" });
        }
    }
}
