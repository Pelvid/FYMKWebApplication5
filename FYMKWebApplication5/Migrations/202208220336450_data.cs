namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data : DbMigration
    {
        public override void Up()
        {
            //DropPrimaryKey("dbo.Mentees");
            //AddColumn("dbo.Mentees", "MenteeId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Mentees", "MenteeId");
            //DropColumn("dbo.Mentees", "Id");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Mentees", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Mentees");
            DropColumn("dbo.Mentees", "MenteeId");
            //AddPrimaryKey("dbo.Mentees", "Id");
        }
    }
}
