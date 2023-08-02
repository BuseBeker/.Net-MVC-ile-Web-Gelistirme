namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_allupdate_090420230840 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Applications", "UserID", "dbo.Users");
            DropIndex("dbo.Applications", new[] { "UserID" });
            DropPrimaryKey("dbo.UserRoles");
            AddColumn("dbo.Applications", "Name", c => c.String(maxLength: 500));
            AddColumn("dbo.Applications", "Surname", c => c.String(maxLength: 500));
            AlterColumn("dbo.Applications", "Project_name", c => c.String(maxLength: 500));
            AlterColumn("dbo.Applications", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.Applications", "ProjectType", c => c.String(maxLength: 500));
            AlterColumn("dbo.Users", "Name", c => c.String(maxLength: 500));
            AlterColumn("dbo.Users", "Email", c => c.String(maxLength: 500));
            AlterColumn("dbo.Users", "Rumuz", c => c.String(maxLength: 500));
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 500));
            AlterColumn("dbo.Users", "Hobbies", c => c.String(maxLength: 500));
            AlterColumn("dbo.UserRoles", "Assigner", c => c.String(maxLength: 500));
            AddPrimaryKey("dbo.UserRoles", new[] { "UserID", "RoleID" });
            DropColumn("dbo.Users", "Surname");
            DropColumn("dbo.UserRoles", "UserRoleID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserRoles", "UserRoleID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Users", "Surname", c => c.String(maxLength: 1000));
            DropPrimaryKey("dbo.UserRoles");
            AlterColumn("dbo.UserRoles", "Assigner", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Users", "Hobbies", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Users", "Rumuz", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Users", "Email", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Users", "Name", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Applications", "ProjectType", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Applications", "Description", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Applications", "Project_name", c => c.String(maxLength: 1000));
            DropColumn("dbo.Applications", "Surname");
            DropColumn("dbo.Applications", "Name");
            AddPrimaryKey("dbo.UserRoles", "UserRoleID");
            CreateIndex("dbo.Applications", "UserID");
            AddForeignKey("dbo.Applications", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
        }
    }
}
