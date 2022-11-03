namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhonePostalChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Mentees", "PostalCode", c => c.String());
            AlterColumn("dbo.Mentees", "Telephone", c => c.String());
            AlterColumn("dbo.Mentees", "PostalCod", c => c.String());
            AlterColumn("dbo.Mentees", "Postal", c => c.String());
            AlterColumn("dbo.Mentees", "PostalCo", c => c.String());
            AlterColumn("dbo.Mentees", "Telephonee", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mentees", "Telephonee", c => c.Int(nullable: false));
            AlterColumn("dbo.Mentees", "PostalCo", c => c.Int(nullable: false));
            AlterColumn("dbo.Mentees", "Postal", c => c.Int(nullable: false));
            AlterColumn("dbo.Mentees", "PostalCod", c => c.Int(nullable: false));
            AlterColumn("dbo.Mentees", "Telephone", c => c.Int(nullable: false));
            AlterColumn("dbo.Mentees", "PostalCode", c => c.Int(nullable: false));
        }
    }
}
