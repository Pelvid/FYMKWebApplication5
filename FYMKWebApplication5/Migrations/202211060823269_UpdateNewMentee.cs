namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNewMentee : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NewMentes", "postalCode", c => c.String());
            AlterColumn("dbo.NewMentes", "telephone", c => c.String());
            AlterColumn("dbo.NewMentes", "postalCodee", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NewMentes", "postalCodee", c => c.Int(nullable: false));
            AlterColumn("dbo.NewMentes", "telephone", c => c.Int(nullable: false));
            AlterColumn("dbo.NewMentes", "postalCode", c => c.Int(nullable: false));
        }
    }
}
