using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FYMKWebApplication5.Models
{
    public class Response
    {
        public int Id { get; set; }
        
        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "Your FirstName Is Require")]
        public string Mentee_FirstName { get; set; }
        
        [Display(Name = "LastName")]
        [Required(ErrorMessage = "Your LastName Is Require")]
        public string Mentee_LastName { get; set; }
        
        [Required(ErrorMessage = "Input Your Mentor Name")]
        public string MentorName { get; set; }
        
        [Display(Name = "Opinion")]
        public string Comment { get; set; }


    }
}