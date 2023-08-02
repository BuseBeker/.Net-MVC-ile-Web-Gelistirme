namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_commentRoletableinUsertable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Roles", "User_UserID", "dbo.Users");
            DropIndex("dbo.Roles", new[] { "User_UserID" });
            DropColumn("dbo.Roles", "User_UserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "User_UserID", c => c.Int());
            CreateIndex("dbo.Roles", "User_UserID");
            AddForeignKey("dbo.Roles", "User_UserID", "dbo.Users", "UserID");
        }
    }
}
