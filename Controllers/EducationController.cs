using PortfolyoProjectNight_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolyoProjectNight_2.Controllers
{
    public class EducationController : Controller
    {
        DbMyPortfolioNight_3Entities2 contex = new DbMyPortfolioNight_3Entities2();
        public ActionResult EducationList()
        {
            var value=contex.Education.ToList();
            return View(value);
        }
        public ActionResult DeleteEducation(int id)
        {
            var value = contex.Education.Find(id);
            contex.Education.Remove(value);
            contex.SaveChanges();
            return RedirectToAction("EducationList");
        }
        [HttpGet]
        public ActionResult CreateAducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAducation(Education education)
        {
            contex.Education.Add(education);
            contex.SaveChanges();
            return RedirectToAction("EducationList");
        }

        [HttpGet]
        public ActionResult UpdateAducation(int id)
        {
            var value = contex.Education.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAducation(Education education)
        {
            var value = contex.Education.Find(education.EducationId);
            value.Title= education.Title;
            value.SubTitle= education.SubTitle;
            value.Description= education.Description;
            contex.SaveChanges();
            return RedirectToAction("EducationList");
        }
    }
}