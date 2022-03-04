using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FYMKWebApplication5.Models;
using System.Data.SqlClient;

namespace FYMKWebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        //private void FetchData()
        //{

        //}
    }
}
