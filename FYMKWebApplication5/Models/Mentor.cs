using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FYMKWebApplication4.Models
{
    public class Mentor
    {
        public int MentorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Display(Name = "Address Line 1")]
        public string Address { get; set; }
        [Display(Name = "Address Line 2")]
        public string Addresss { get; set; }
        public string City { get; set; }
        [Display(Name = "State / Province / Region")]
        public string State { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        public string Country { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int Telephone { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Compare("Email", ErrorMessage = "Pleasea confirm your Email.")]
        [Display(Name = "Confirm Email")]
        public string ConrirmEmail { get; set; }
        [Required(ErrorMessage = "Choose date of birth")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Choose your gender")]
        public string Gender { get; set; }

        [Display(Name = "Do you have prefrence on Gender?")]
        public string PrefrenceOnGender { get; set; }
        [Display(Name = "Is English your first language?")]
        public string FirstLanguage { get; set; }
        [Display(Name = "Do you have Criminal Conviction?")]
        public string CriminalConvivtion { get; set; }
        [Display(Name = "Do you have an enhanced DBS certificates?")]
        public string DBSCertificate { get; set; }
        [Display(Name = "If Yes, what is your updated DBS number?")]
        public string UpdatedDBS { get; set; }
        [Display(Name = "What Education qualification do you have")]
        public bool GCSE { get; set; }
        [Display(Name = "A Levels")]
        public bool ALevel { get; set; }
        [Display(Name = "Higher Education / University")]
        public bool Higher { get; set; }

        [Display(Name = "Are you studying ow working? Tell us whuch industry / Sector you arfe in")]
        public string StudyingOrWorking { get; set; }
        [Display(Name = "Most recent Institute / University or Employer's Name & Address")]
        public string InstituteOrUniversity { get; set; }
        [Display(Name = "Role & Responsibility or Course Studying")]
        public string CourseStudying { get; set; }
        [Display(Name = "Start date in school")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Display(Name = "End date in school")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        [Display(Name = "Volunteer Exprience")]
        public string Volunteer { get; set; }
        [Display(Name = "Please tell us why you want to mentor through our organisation?")]
        public string WhyYouWantToMentor { get; set; }
        [Display(Name = "Please tell us what you hope to gain from your experience with us as a mentor?")]
        public string YourExperience { get; set; }
        [Display(Name = "When are you available to mentor?")]
        public string WhenAreYouAvailable { get; set; }
        [Display(Name = "Skills, Hobbies and Special Interest")]
        public string SkillHobbies { get; set; }
        [Display(Name = "Do you have any special needs you would like to share?")]
        public string SpecialNeed { get; set; }
        [Display(Name = "Any other comments or information")]
        public string Comment { get; set; }
        [Display(Name = "Which area would you prefer to mantor?")]
        public bool Education { get; set; }
        public bool Enterpreneurship { get; set; }
        public bool Employement { get; set; }
        [Display(Name = "Which Mentee goals could you help with?")]
        public bool Developing_Resilence { get; set; }
        public bool Volunteering { get; set; }
        public bool Changing_Career { get; set; }
        public bool Building_Confidence { get; set; }
        public bool Getting_Involved_In_Community_Work { get; set; }
        public bool Career_Without_University { get; set; }
        public bool Finding_Jobs_Locally { get; set; }
        public bool Developing_A_Professional_Network { get; set; }
        public bool CV_Writting { get; set; }
        public bool University_Applications { get; set; }
        public bool Interview_Skills { get; set; }
        public bool MyProperty { get; set; }
        [Display(Name = "Your Hobbies and interests (Tick Applicable)")]
        public bool Visual_Arts { get; set; }
        public bool Watching_Films { get; set; }
        public bool Creating_Videos { get; set; }
        public bool Reading_Fiction { get; set; }
        public bool Litary_Works { get; set; }
        public bool Sport { get; set; }
        public bool Electronic_Video_Game { get; set; }
        public bool Music { get; set; }
        public bool Baking { get; set; }
        public bool Cooking { get; set; }
        public bool Volunteeringg { get; set; }

        [Display(Name = "What are your other professional interests apart from the listed options abve?")]
        public string ProfessionalInterest { get; set; }
        [Display(Name = "Science & Technology")]
        public bool Science { get; set; }
        [Display(Name = "Information & Technology")]
        public bool Information { get; set; }
        [Display(Name = "Financial Services")]
        public bool FInancial { get; set; }
        [Display(Name = "Education")]
        public bool Educations { get; set; }
        [Display(Name = "Business & Development")]
        public bool Business { get; set; }
        [Display(Name = "Legal & Litigation")]
        public bool Legal { get; set; }
        [Display(Name = "Healthcare & Medicine")]
        public bool HealthCare { get; set; }
        [Display(Name = "Engineering  Publishing")]
        public bool Engineering { get; set; }
        [Display(Name = "Non-Profit Administration (Charity)")]
        public bool Non_Profit { get; set; }
        [Display(Name = "Politics")]
        public bool Politics { get; set; }
        [Display(Name = "Mmarketting & Advertising")]
        public bool Marketting { get; set; }
        [Display(Name = "What are your other professional interest apart from the lisyted above ")]
        public string Other { get; set; }
        [Display(Name = "What Best describe you? (Tick Applicably)")]
        public bool Outgoing { get; set; }
        [Display(Name = "Funny")]
        public bool Funny { get; set; }
        [Display(Name = "Lively")]
        public bool Lively { get; set; }
        [Display(Name = "Business-Oriented")]
        public bool Businesss { get; set; }
        [Display(Name = "Construtive")]
        public bool Construtive { get; set; }
        public bool Emphathetic { get; set; }
        public bool Intuitive { get; set; }
        public bool Passionate { get; set; }
        public bool Reserved { get; set; }
        public bool Reflective { get; set; }
        public bool Vibrant { get; set; }
        [Display(Name = "Other (Please Specify)")]
        public string Others { get; set; }
        [Display(Name = "Name")]
        public string Refenrence { get; set; }
        [Display(Name = "Address Line 1")]
        public string Addressss { get; set; }
        [Display(Name = "Address Line 2")]
        public string Address2 { get; set; }
        [Display(Name = "City")]
        public string Cityy { get; set; }
        [Display(Name = "State / Province / Region")]
        public string Region { get; set; }
        [Display(Name = "Postal Code")]
        public string Code { get; set; }
        [Display(Name = "Country")]
        public string Countryy { get; set; }
        [Display(Name = "Telephone")]
        [DataType(DataType.PhoneNumber)]
        public int Telephonee { get; set; }

        [Display(Name = "Name")]
        public string Refenrence2 { get; set; }
        [Display(Name = "Address Line 1")]
        public string Addresssss { get; set; }
        [Display(Name = "Address Line 2")]
        public string AddressTwo { get; set; }
        [Display(Name = "City")]
        public string Cityyy { get; set; }
        [Display(Name = "State / Province / Region")]
        public string Regionn { get; set; }
        [Display(Name = "Postal Code")]
        public string Codee { get; set; }
        [Display(Name = "Country")]
        public string Countryyy { get; set; }
        [Display(Name = "Telephone")]
        [DataType(DataType.PhoneNumber)]
        public int Telephoneee { get; set; }
        [Display(Name = "Final Note")]
        public string FinalNote { get; set; }
        [Display(Name = "GDPR Agreement")]
        public bool GDPR { get; set; }

        //Foreign Key
        public int MenteeId { get; set; }
        //public int MenteeId { get; set; }
        //public int MentorStringId { get; set; }
        //Navigation Property
        //public Mentee Mentee { get; set; }
    }
}