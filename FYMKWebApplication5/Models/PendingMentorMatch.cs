using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FYMKWebApplication5.Models
{
    public class PendingMentorMatch
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Enterpreneurship { get; set; }
        public string Education { get; set; }
        public string MenteeId { get; set; }
        public string MentorId { get; set; }
    }
}