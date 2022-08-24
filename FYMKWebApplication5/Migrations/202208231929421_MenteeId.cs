namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MenteeId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Mentors", "MenteeId");

            AddColumn("dbo.Mentors", "MenteeId", c => c.Int(nullable: true));

        }

        public override void Down()
        {
        }
    }
}
