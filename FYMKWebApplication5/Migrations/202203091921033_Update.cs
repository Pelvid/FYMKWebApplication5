namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mentees", "Male", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mentees", "Female", c => c.Boolean(nullable: false));
            DropColumn("dbo.Mentees", "Gender");
        }
        
        //public override void Down()
        //{
        //    AddColumn("dbo.Mentees", "Gender", c => c.Boolean(nullable: false));
        //    DropColumn("dbo.Mentees", "Female");
        //    DropColumn("dbo.Mentees", "Male");
        //}

    }
}
