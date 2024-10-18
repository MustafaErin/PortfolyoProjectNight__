using PortfolyoProjectNight_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolyoProjectNight_2.Controllers
{
    public class ContactController : Controller
    {
        DbMyPortfolioNight_3Entities2 contex = new DbMyPortfolioNight_3Entities2();
        // GET: Contact
        public PartialViewResult PartialContactSidebar()
        {
            return PartialView();
        }
        public PartialViewResult PartialContactDetail()
        {
            ViewBag.Address = contex.Profile.Select(x => x.Address).FirstOrDefault();
            ViewBag.Description = contex.Profile.Select(x => x.Description).FirstOrDefault();
            ViewBag.Phone = contex.Profile.Select(x => x.Phone).FirstOrDefault();
            ViewBag.email = contex.Profile.Select(x => x.email).FirstOrDefault();
            ViewBag.date=contex.Profile.Select(x=>x.Title).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialContactLocation()
        {
            return PartialView();
        }
    }
}