using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FYMKWebApplication5.Models
{
    public class MatchingRatio
    {
        public string MenteeId { get; set; }
        public string MentorId { get; set; }
        public string Total_Matched { get; set; }
    }
}