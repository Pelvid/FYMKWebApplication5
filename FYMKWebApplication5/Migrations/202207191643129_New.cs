//namespace FYMKWebApplication5.Migrations
//{
//    using System;
//    using System.Data.Entity.Migrations;
    
//    public partial class New : DbMigration
//    {
//        public override void Up()
//        {
//            DropForeignKey("dbo.Mentees", "MentorId", "dbo.Mentors");
//            //DropPrimaryKey("dbo.Mentors");
//            AddColumn("dbo.Mentors", "MentorId", c => c.Int(nullable: false, identity: true));
//            AddPrimaryKey("dbo.Mentors", "MentorId");
//            AddForeignKey("dbo.Mentees", "MentorId", "dbo.Mentors", "MentorId", cascadeDelete: true);
//            DropColumn("dbo.Mentors", "Id");
//        }
        
//        //public override void Down()
//        //{
//        //    AddColumn("dbo.Mentors", "Id", c => c.Int(nullable: false, identity: true));
//        //    DropForeignKey("dbo.Mentees", "MentorId", "dbo.Mentors");
//        //    //DropPrimaryKey("dbo.Mentors");
//        //    DropColumn("dbo.Mentors", "MentorId");
//        //    AddPrimaryKey("dbo.Mentors", "Id");
//        //    AddForeignKey("dbo.Mentees", "MentorId", "dbo.Mentors", "Id", cascadeDelete: true);
//        //}
//    }
//}
