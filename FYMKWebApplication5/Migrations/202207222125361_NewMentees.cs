namespace FYMKWebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMentees : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewMentes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        address = c.String(),
                        address_line1 = c.String(),
                        address_line2 = c.String(),
                        city = c.String(),
                        stateProvinceRegion = c.String(),
                        postalCode = c.Int(nullable: false),
                        country = c.String(),
                        telephone = c.Int(nullable: false),
                        email = c.String(),
                        dateOfBirth = c.DateTime(nullable: false),
                        gender = c.String(),
                        ethnic_group = c.String(),
                        menteeGenderPreference = c.String(),
                        menteeGender_Preference = c.String(),
                        edHeader = c.String(),
                        GSCE = c.String(),
                        A_levels = c.String(),
                        HED_U = c.String(),
                        address_ = c.String(),
                        address_lineOne = c.String(),
                        address_lineTwo = c.String(),
                        cityy = c.String(),
                        stateProvinceRegionn = c.String(),
                        postalCodee = c.Int(nullable: false),
                        countryy = c.String(),
                        skills_and_hobbies = c.String(),
                        visual_art = c.Boolean(nullable: false),
                        movies_cinema = c.Boolean(nullable: false),
                        creating_videos = c.Boolean(nullable: false),
                        reading = c.Boolean(nullable: false),
                        sports = c.Boolean(nullable: false),
                        video_games = c.Boolean(nullable: false),
                        music = c.Boolean(nullable: false),
                        banking = c.Boolean(nullable: false),
                        cooking = c.Boolean(nullable: false),
                        volunteering = c.Boolean(nullable: false),
                        science_technology = c.String(),
                        financial_services = c.String(),
                        Educa_tion = c.String(),
                        business_development = c.String(),
                        informatoin_technology = c.String(),
                        law_legal_litigation = c.String(),
                        medicine_healthcare = c.String(),
                        engineering = c.String(),
                        publishing = c.String(),
                        non_profit_charity_administration = c.String(),
                        politics = c.String(),
                        marketing_advertising = c.String(),
                        other_professional_interests_div = c.String(),
                        outgoing = c.Boolean(nullable: false),
                        funny = c.Boolean(nullable: false),
                        lively = c.Boolean(nullable: false),
                        business_oriented = c.Boolean(nullable: false),
                        constructive = c.Boolean(nullable: false),
                        empathetic = c.Boolean(nullable: false),
                        intuitive = c.Boolean(nullable: false),
                        passionate = c.Boolean(nullable: false),
                        reserved = c.Boolean(nullable: false),
                        reflective = c.Boolean(nullable: false),
                        vibrant = c.Boolean(nullable: false),
                        other_personal_description_div = c.String(),
                        current_challenges_div = c.String(),
                        expected_gain_div = c.String(),
                        volunteering_div = c.String(),
                        Weekly = c.Boolean(nullable: false),
                        Fortnightly = c.Boolean(nullable: false),
                        Monthly = c.Boolean(nullable: false),
                        One_hour = c.Boolean(nullable: false),
                        OneFive_hour = c.Boolean(nullable: false),
                        Two_hours = c.Boolean(nullable: false),
                        disability_option = c.String(),
                        special_need_brief = c.String(),
                        Educationn = c.Boolean(nullable: false),
                        Employment = c.Boolean(nullable: false),
                        Entrepreneurship = c.Boolean(nullable: false),
                        developing_resilience = c.Boolean(nullable: false),
                        college_options = c.Boolean(nullable: false),
                        career_without_niversity = c.Boolean(nullable: false),
                        building_confidence = c.Boolean(nullable: false),
                        volunteering_ = c.Boolean(nullable: false),
                        interview_skills = c.Boolean(nullable: false),
                        getting_involved_in_community_work = c.Boolean(nullable: false),
                        career_options = c.Boolean(nullable: false),
                        changing_career = c.Boolean(nullable: false),
                        finding_Jobs_locally = c.Boolean(nullable: false),
                        CV_writing = c.Boolean(nullable: false),
                        university_applications = c.Boolean(nullable: false),
                        developing_a_professional_network = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewMentes");
        }
    }
}
