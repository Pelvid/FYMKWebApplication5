using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FYMKWebApplication5.Models
{
    public class AdminDashboard
    {
        public int Id { get; set; }
        public string MentorCount { get; set; }
        public string MenteeCount { get; set; }
    }
}