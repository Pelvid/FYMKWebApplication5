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
        [Display(Name = "Opinion")]
        public string Comment { get; set; }


    }
}