using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FYMKWebApplication5.Models
{
    public class ProfileSettings
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Bio { get; set; }
        public string Location { get; set; }
    }
}