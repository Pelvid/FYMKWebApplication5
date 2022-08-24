namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class latest : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Mentors", "MenteeId");

            AddColumn("dbo.Mentors", "MenteeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
        }
    }
}
