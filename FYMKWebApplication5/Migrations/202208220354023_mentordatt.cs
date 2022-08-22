namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mentordatt : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Mentors", "MenteeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.Mentors", "MenteeId");
        }
    }
}
