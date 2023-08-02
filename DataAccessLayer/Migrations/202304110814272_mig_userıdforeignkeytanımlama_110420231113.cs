namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_userıdforeignkeytanımlama_110420231113 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Applications", "UserID");
            AddForeignKey("dbo.Applications", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Applications", "UserID", "dbo.Users");
            DropIndex("dbo.Applications", new[] { "UserID" });
        }
    }
}
