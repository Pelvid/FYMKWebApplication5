namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResponseUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Responses", "Mentee_FirstName", c => c.String(nullable: false));
            AddColumn("dbo.Responses", "Mentee_LastName", c => c.String(nullable: false));
            AddColumn("dbo.Responses", "MentorName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Responses", "MentorName");
            DropColumn("dbo.Responses", "Mentee_LastName");
            DropColumn("dbo.Responses", "Mentee_FirstName");
        }
    }
}
