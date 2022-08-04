namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stupid : DbMigration
    {
        public override void Up()
        {
            //DropTable("dbo.Reports");
        }
        
        public override void Down()
        {
            //CreateTable(
            //    "dbo.Reports",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Understanding = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
        }
    }
}
