namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MentorPhonePostalChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Mentors", "Telephone", c => c.String());
            AlterColumn("dbo.Mentors", "Telephonee", c => c.String());
            AlterColumn("dbo.Mentors", "Telephoneee", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mentors", "Telephoneee", c => c.Int(nullable: false));
            AlterColumn("dbo.Mentors", "Telephonee", c => c.Int(nullable: false));
            AlterColumn("dbo.Mentors", "Telephone", c => c.Int(nullable: false));
        }
    }
}
