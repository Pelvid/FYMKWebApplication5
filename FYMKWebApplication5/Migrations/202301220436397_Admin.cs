namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Admin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Re_TypePassword = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
