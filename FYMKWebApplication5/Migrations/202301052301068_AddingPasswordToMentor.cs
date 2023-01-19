namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPasswordToMentor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mentors", "Male", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mentors", "Female", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mentors", "MentorMale", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mentors", "MentorFemale", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mentors", "Username", c => c.String());
            AddColumn("dbo.Mentors", "Password", c => c.String());
            AddColumn("dbo.Mentors", "Re_TypePassword", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mentors", "Re_TypePassword");
            DropColumn("dbo.Mentors", "Password");
            DropColumn("dbo.Mentors", "Username");
            DropColumn("dbo.Mentors", "MentorFemale");
            DropColumn("dbo.Mentors", "MentorMale");
            DropColumn("dbo.Mentors", "Female");
            DropColumn("dbo.Mentors", "Male");
        }
    }
}
