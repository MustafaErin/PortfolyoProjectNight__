using PortfolyoProjectNight_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolyoProjectNight_2.Controllers
{
    public class AdminController : Controller
    {
        DbMyPortfolioNight_3Entities2 contex = new DbMyPortfolioNight_3Entities2();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialSidebar()
        {
            ViewBag.foto=contex.About.Where(x=>x.AboutId==3).Select(y=>y.İmgUrl).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialNavbar() 
        {
            return PartialView();
        }

        public PartialViewResult PartialScripts() 
        { 
            return PartialView();
        }

    }
}