namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_dusertableupdatestringlength_180420230252 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Name", c => c.String(maxLength: 60));
            AlterColumn("dbo.Users", "Surname", c => c.String(maxLength: 60));
            AlterColumn("dbo.Users", "Email", c => c.String(maxLength: 60));
            AlterColumn("dbo.Users", "Phone", c => c.String(maxLength: 15));
            AlterColumn("dbo.Users", "Rumuz", c => c.String(maxLength: 60));
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 60));
            AlterColumn("dbo.Users", "Hobbies", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Hobbies", c => c.String(maxLength: 500));
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 500));
            AlterColumn("dbo.Users", "Rumuz", c => c.String(maxLength: 500));
            AlterColumn("dbo.Users", "Phone", c => c.String(maxLength: 13));
            AlterColumn("dbo.Users", "Email", c => c.String(maxLength: 500));
            AlterColumn("dbo.Users", "Surname", c => c.String(maxLength: 500));
            AlterColumn("dbo.Users", "Name", c => c.String(maxLength: 500));
        }
    }
}
