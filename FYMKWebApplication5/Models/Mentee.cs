using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace FYMKWebApplication4.Models
{
    //MentorCount mentorCount = new MentorCount();

    public class Mentee
    {
        public int MenteeId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Display(Name = "Address Line 1")]

        public string Address1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string Address { get; set; }
        public string City { get; set; }
        [Display(Name = "State / Province / Region")]
        public string State { get; set; }

        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }
        public string Countries { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Compare("Email", ErrorMessage = "Pleasea confirm your Email.")]
        [Display(Name = "Confirm Email")]
        [DataType(DataType.EmailAddress)]
        public string Confirm { get; set; }

        //[Required(ErrorMessage = "Choose date of birth")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime MyProperty { get; set; }
        [Required(ErrorMessage = "Choose your gender")]

        public string Gender { get; set; }
        [Display(Name = "What is your Ethic group?")]
        public string EthicGroup { get; set; }
        [Display(Name = "Do you have preference on gender of Mentor?")]
        public string Prefenrene { get; set; }
        [Display(Name = "Is your Language English?")]
        public string YourLanguage { get; set; }
        //In Education Or Working
        [Display(Name = "In Education {Full Time}")]
        public bool Role { get; set; }
        [Display(Name = "In Education {Part Time}")]
        public bool PartT_Time { get; set; }
        [Display(Name = "Graduated")]
        public bool Graduated { get; set; }
        [Display(Name = "In Training (Incl. Apprenticeship)")]
        public bool Training { get; set; }
        [Display(Name = "Working(Full-Time)")]
        public bool Working { get; set; }
        [Display(Name = "Working(Part-Time)")]
        public bool Working_Part_Time { get; set; }
        [Display(Name = "Unemployed")]
        public bool Unemployed { get; set; }
        //[Display(Name = "What Education qualification are you preparing for?")]
        public bool GSCE { get; set; }
        public bool A_Levels { get; set; }
        [Display(Name = "Higher Education / University")]
        public bool Higher { get; set; }
        [Display(Name = "Name and Address of School / College / University")]
        public string NameAddress { get; set; }
        [Display(Name = "Address line 1")]
        public string NameAddres { get; set; }
        [Display(Name = "Address line 2")]
        public string NameAdre { get; set; }
        [Display(Name = "City")]
        public string Citt { get; set; }
        [Display(Name = "state / province / region")]
        public string Province { get; set; }
        [DataType(DataType.PostalCode)]
        [Display(Name = "Postal Code")]
        public string PostalCod { get; set; }
        [Required]
        [Display(Name = "Country")]
        public string SelectedCountryIso32 { get; set; }
        //[Required(ErrorMessage = "Choose date of birth")]
        [Display(Name = "Date started in school")]
        [DataType(DataType.Date)]
        public DateTime MyPropert { get; set; }
        //[Required(ErrorMessage = "Choose date of birth")]
        [Display(Name = "End date in school")]
        [DataType(DataType.Date)]
        public DateTime MyProper { get; set; }
        [Display(Name = "Volunteer or Community Experience")]
        public string Comment { get; set; }
        [Display(Name = "Please tell us what you hope to gain from youe experience with us as a mentee?")]
        public string PleaseTellUs { get; set; }
        //[Display(Name = "How often would you like your monitoring session?")]
        public bool Weekly { get; set; }
        public bool Fortnight { get; set; }
        public bool Monthly { get; set; }
        //[Display(Name = "How long would you like your session to last?")]
        [Display(Name = "1 hour")]
        public bool ONE_HOUR { get; set; }
        [Display(Name = "1.5 hour")]
        public bool ONE_FIVE { get; set; }
        [Display(Name = "2 hour")]
        public bool TWO_HOUR { get; set; }
        [Display(Name = "Skills, Hobbies and Special Need")]
        public string Skills { get; set; }
        //[Display(Name = "Do you have any dissabilities or special needs you would like to share with us?")]
        [Display(Name = "If yes check the box")]
        public bool If_Yes { get; set; }
        //[Display(Name = "Which area would you like to mentored?")]
        public bool Education { get; set; }
        public bool Enterpreneurship { get; set; }
        public bool Employment { get; set; }
        //[Display(Name = "Which goals are you interested in?")]
        [Display(Name = "University Application")]
        public bool University { get; set; }
        [Display(Name = "Building Confidence")]
        public bool Building { get; set; }
        [Display(Name = "Developing a professional network")]
        public bool Developing { get; set; }
        [Display(Name = "Developing Resilience")]
        public bool Resilence { get; set; }
        [Display(Name = "Volunteering")]
        public bool Volunteering { get; set; }
        [Display(Name = "College Options")]
        public bool College { get; set; }
        [Display(Name = "Career without University")]
        public bool Career { get; set; }
        [Display(Name = "Career Options")]
        public bool CareerOptions { get; set; }
        [Display(Name = "CV Writting")]
        public bool CV { get; set; }
        [Display(Name = "Getting involved in community work")]
        public bool Getting { get; set; }
        [Display(Name = "Finding Jobs Locally")]
        public bool Finding { get; set; }
        [Display(Name = "Changing Career")]
        public bool ChangingCareer { get; set; }
        [Display(Name = "Interview Skills")]
        public bool Interview { get; set; }
        //[Display(Name = "Your Hobbies and interests (Tick Applicable)")]
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

        [Display(Name = "Professional Interest(Tick Applicable)")]
        public bool ProfessionalInterestt { get; set; }
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

        [Display(Name = "Other(Please Specify)")]
        public string Others { get; set; }
        [Display(Name = "Do you have a criminal conviction or warnings?")]
        public string Criminal { get; set; }

        public string References { get; set; }
        [Display(Name = "Refenreces 1")]
        public string Refenrece { get; set; }
        [Display(Name = "Address")]
        public string Addres { get; set; }
        [Display(Name = "Address 2")]
        public string Addre { get; set; }
        [Display(Name = "City")]
        public string Sity { get; set; }
        [Display(Name = "State / Province / Region")]
        public string Region { get; set; }
        [DataType(DataType.PostalCode)]
        [Display(Name = "PostalCode")]
        public string Postal { get; set; }
        [Required]
        [Display(Name = "Country")]
        public string SelectedCountryIso3 { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Emai { get; set; }
        [Display(Name = "Telephone")]
        public string Reference { get; set; }
        [Display(Name = "Refenreces 1")]
        public string Refenrec { get; set; }
        [Display(Name = "Address")]
        public string Adde { get; set; }
        [Display(Name = "Address 2")]
        public string Addr { get; set; }
        [Display(Name = "City")]
        public string zity { get; set; }
        [Display(Name = "State / Province / Region")]
        public string Regio { get; set; }
        [Display(Name = "PostalCode")]
        public string PostalCo { get; set; }
        [Required]
        [Display(Name = "Country")]
        public string SelectedCountryIso33 { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Emaill { get; set; }
        [Display(Name = "Telephone")]
        public string Telephonee { get; set; }
        [Display(Name = "Final Note")]
        public string Note { get; set; }


        public bool Male { get; set; }
        public bool Female { get; set; }
        public bool MentorMale { get; set; }
        public bool MentorFemale { get; set; }

        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Please confirm your Password.")]
        [DataType(DataType.Password)]
        public string Re_TypePassword { get; set; }


        //Foreign Key
        public int MentorId { get; set; }
        //public int MenteeStringId { get; set; }

        //Navigation Property
        public Mentor Mentor { get; set; }
    }



    class MentorCount
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }



}