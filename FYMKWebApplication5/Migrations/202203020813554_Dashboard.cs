namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dashboard : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminDashboards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MentorCount = c.String(),
                        MenteeCount = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AdminDashboards");
        }
    }
}
