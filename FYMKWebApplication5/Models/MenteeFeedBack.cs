using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FYMKWebApplication5.Models
{
    public class MenteeFeedBack
    {
        public string Id { get; set; }
        public string Comment { get; set; }
        public string Mentee_FirstName { get; set; }
        public string Mentee_LastName { get; set; }
        public string MentorName { get; set; }
    }
}