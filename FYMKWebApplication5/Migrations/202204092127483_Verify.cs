namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Verify : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Verifies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Csharp = c.Boolean(nullable: false),
                        Python = c.Boolean(nullable: false),
                        CSS = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        //public override void Down()
        //{
        //    DropTable("dbo.Verifies");
        //}
    }
}
