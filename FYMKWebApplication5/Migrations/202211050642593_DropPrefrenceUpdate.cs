namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropPrefrenceUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mentees", "Prefenrene", c => c.String());
            DropColumn("dbo.Mentees", "Male");
            DropColumn("dbo.Mentees", "Female");
            DropColumn("dbo.Mentees", "Both");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Mentees", "Both", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mentees", "Female", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mentees", "Male", c => c.Boolean(nullable: false));
            DropColumn("dbo.Mentees", "Prefenrene");
        }
    }
}
