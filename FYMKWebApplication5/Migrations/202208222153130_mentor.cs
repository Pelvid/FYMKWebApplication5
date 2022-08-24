namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mentor : DbMigration
    {
        public override void Up()
        {

            AddColumn("dbo.Mentors", "MenMenteeId", c => c.Int(nullable: false));

        }

        public override void Down()
        {
            DropColumn("dbo.Mentors", "MenteeId");

        }
    }
}
