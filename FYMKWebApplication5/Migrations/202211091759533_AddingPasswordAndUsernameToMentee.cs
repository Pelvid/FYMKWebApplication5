namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPasswordAndUsernameToMentee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mentees", "Male", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mentees", "Female", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mentees", "MentorMale", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mentees", "MentorFemale", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mentees", "Username", c => c.String());
            AddColumn("dbo.Mentees", "Password", c => c.String());
            AddColumn("dbo.Mentees", "Re_TypePassword", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mentees", "Re_TypePassword");
            DropColumn("dbo.Mentees", "Password");
            DropColumn("dbo.Mentees", "Username");
            DropColumn("dbo.Mentees", "MentorFemale");
            DropColumn("dbo.Mentees", "MentorMale");
            DropColumn("dbo.Mentees", "Female");
            DropColumn("dbo.Mentees", "Male");
        }
    }
}
