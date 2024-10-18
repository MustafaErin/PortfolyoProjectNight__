using PortfolyoProjectNight_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolyoProjectNight_2.Controllers
{
    public class DashboardController : Controller
    {
        DbMyPortfolioNight_3Entities2 context = new DbMyPortfolioNight_3Entities2();
        // GET: Dashboard
        public ActionResult Index()
        {
            
            return View();
        }
    }
}