namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Profile : DbMigration
    {
        public override void Up()
        {
           
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Bio = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mentees", "MentorId", "dbo.Mentors");
            DropIndex("dbo.Mentees", new[] { "MentorId" });
          
            DropTable("dbo.Mentors");
            DropTable("dbo.Mentees");
            DropTable("dbo.AdminDashboards");
        }
    }
}
