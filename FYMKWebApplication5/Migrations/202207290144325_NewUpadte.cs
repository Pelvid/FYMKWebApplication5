namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewUpadte : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NewMentes", "GSCE", c => c.Boolean(nullable: true));
            AlterColumn("dbo.NewMentes", "A_levels", c => c.Boolean(nullable: true));
            AlterColumn("dbo.NewMentes", "HED_U", c => c.Boolean(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NewMentes", "HED_U", c => c.String());
            AlterColumn("dbo.NewMentes", "A_levels", c => c.String());
            AlterColumn("dbo.NewMentes", "GSCE", c => c.String());
        }
    }
}
