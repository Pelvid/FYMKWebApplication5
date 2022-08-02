using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FYMKWebApplication5.Models
{
    public class NewMente
    {
        //[Key]
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string address_line1 { get; set; }
        public string address_line2 { get; set; }
        public string city { get; set; }
        public string stateProvinceRegion { get; set; }
        [DataType(DataType.PostalCode)]
        public int postalCode { get; set; }
        public string country { get; set; }
        public int telephone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [DataType(DataType.Date)]
        public DateTime dateOfBirth { get; set; }
        public string gender { get; set; }
        public string ethnic_group { get; set; }
        public string menteeGenderPreference { get; set; }
        public string menteeGender_Preference { get; set; }
        public string edHeader { get; set; }
        public bool GSCE { get; set; }
        public bool A_levels { get; set; }
        public bool HED_U { get; set; }      
        public string address_ { get; set; }
        public string address_lineOne { get; set; }
        public string address_lineTwo { get; set; }
        public string cityy { get; set; }
        public string stateProvinceRegionn { get; set; }
        [DataType(DataType.PostalCode)]

        public int postalCodee { get; set; }
        public string countryy { get; set; }
        public string skills_and_hobbies { get; set; }
        public bool visual_art { get; set; }
        public bool movies_cinema { get; set; }
        public bool creating_videos { get; set; }
        public bool reading { get; set; }
        public bool sports { get; set; }
        public bool video_games { get; set; }
        public bool music { get; set; }
        public bool banking { get; set; }
        public bool cooking { get; set; }
        public bool volunteering { get; set; }

        //form-div_professional_and_career-interest-div
        public bool science_technology { get; set; }
        public bool financial_services { get; set; }
        public bool Educa_tion { get; set; }
        public bool business_development { get; set; }
        public bool informatoin_technology { get; set; }
        public bool law_legal_litigation { get; set; }
        public bool medicine_healthcare { get; set; }
        public bool engineering { get; set; }
        public bool publishing { get; set; }
        public bool non_profit_charity_administration { get; set; }
        public bool politics { get; set; }
        public bool marketing_advertising { get; set; }
        [Display(Name = "Other Professional Interests apart from the ones listed above")]
        public string other_professional_interests_div { get; set; }

        //form-div_personal-description-div
        public bool outgoing { get; set; }
        public bool funny { get; set; }
        public bool lively { get; set; }
        public bool business_oriented { get; set; }
        public bool constructive { get; set; }
        public bool empathetic { get; set; }
        public bool intuitive { get; set; }
        public bool passionate { get; set; }
        public bool reserved { get; set; }
        public bool reflective { get; set; }
        public bool vibrant { get; set; }
        public string other_personal_description_div { get; set; }
        public string current_challenges_div { get; set; }
        public string expected_gain_div { get; set; }
        public string volunteering_div { get; set; }

        //mentoring-session-div
        public bool Weekly { get; set; }
        public bool Fortnightly { get; set; }
        public bool Monthly { get; set; }

        //How often would you like your mentoring sessions? 
        public bool One_hour { get; set; }
        public bool OneFive_hour { get; set; }
        public bool Two_hours { get; set; }

        //disability-option_div
        public string disability_option { get; set; }
        public string special_need_brief { get; set; }

        //area-of-mentorship-div
        public bool Educationn { get; set; }
        public bool Employment { get; set; }
        public bool Entrepreneurship { get; set; }

        //interested-goals-div
        public bool developing_resilience { get; set; }
        public bool college_options { get; set; }
        public bool career_without_niversity { get; set; }
        public bool building_confidence { get; set; }
        public bool volunteering_ { get; set; }
        public bool interview_skills { get; set; }
        public bool getting_involved_in_community_work { get; set; }
        public bool career_options { get; set; }
        public bool changing_career { get; set; }
        public bool finding_Jobs_locally { get; set; }
        public bool CV_writing { get; set; }
        public bool university_applications { get; set; }
        public bool developing_a_professional_network { get; set; }

        //mentee_profile_form_submitBTN_div
    }
}