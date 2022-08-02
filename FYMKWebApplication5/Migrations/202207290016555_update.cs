namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NewMentes", "science_technology", c => c.Boolean(nullable: true));
            AlterColumn("dbo.NewMentes", "financial_services", c => c.Boolean(nullable: true));
            AlterColumn("dbo.NewMentes", "Educa_tion", c => c.Boolean(nullable: true));
            AlterColumn("dbo.NewMentes", "business_development", c => c.Boolean(nullable: true));
            AlterColumn("dbo.NewMentes", "informatoin_technology", c => c.Boolean(nullable: true));
            AlterColumn("dbo.NewMentes", "law_legal_litigation", c => c.Boolean(nullable: true));
            AlterColumn("dbo.NewMentes", "medicine_healthcare", c => c.Boolean(nullable: true));
            AlterColumn("dbo.NewMentes", "engineering", c => c.Boolean(nullable: true));
            AlterColumn("dbo.NewMentes", "publishing", c => c.Boolean(nullable: true));
            AlterColumn("dbo.NewMentes", "non_profit_charity_administration", c => c.Boolean(nullable: true));
            AlterColumn("dbo.NewMentes", "politics", c => c.Boolean(nullable: true));
            AlterColumn("dbo.NewMentes", "marketing_advertising", c => c.Boolean(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NewMentes", "marketing_advertising", c => c.String());
            AlterColumn("dbo.NewMentes", "politics", c => c.String());
            AlterColumn("dbo.NewMentes", "non_profit_charity_administration", c => c.String());
            AlterColumn("dbo.NewMentes", "publishing", c => c.String());
            AlterColumn("dbo.NewMentes", "engineering", c => c.String());
            AlterColumn("dbo.NewMentes", "medicine_healthcare", c => c.String());
            AlterColumn("dbo.NewMentes", "law_legal_litigation", c => c.String());
            AlterColumn("dbo.NewMentes", "informatoin_technology", c => c.String());
            AlterColumn("dbo.NewMentes", "business_development", c => c.String());
            AlterColumn("dbo.NewMentes", "Educa_tion", c => c.String());
            AlterColumn("dbo.NewMentes", "financial_services", c => c.String());
            AlterColumn("dbo.NewMentes", "science_technology", c => c.String());
        }
    }
}
