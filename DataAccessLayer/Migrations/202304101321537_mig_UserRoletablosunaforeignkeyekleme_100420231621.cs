namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_UserRoletablosunaforeignkeyekleme_100420231621 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.UserRoles", name: "RoleID", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.UserRoles", name: "UserID", newName: "RoleID");
            RenameColumn(table: "dbo.UserRoles", name: "__mig_tmp__0", newName: "UserID");
            RenameIndex(table: "dbo.UserRoles", name: "IX_RoleID", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.UserRoles", name: "IX_UserID", newName: "IX_RoleID");
            RenameIndex(table: "dbo.UserRoles", name: "__mig_tmp__0", newName: "IX_UserID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.UserRoles", name: "IX_UserID", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.UserRoles", name: "IX_RoleID", newName: "IX_UserID");
            RenameIndex(table: "dbo.UserRoles", name: "__mig_tmp__0", newName: "IX_RoleID");
            RenameColumn(table: "dbo.UserRoles", name: "UserID", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.UserRoles", name: "RoleID", newName: "UserID");
            RenameColumn(table: "dbo.UserRoles", name: "__mig_tmp__0", newName: "RoleID");
        }
    }
}
