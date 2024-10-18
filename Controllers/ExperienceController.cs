using PortfolyoProjectNight_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolyoProjectNight_2.Controllers
{

   
    public class ExperienceController : Controller
    {
        DbMyPortfolioNight_3Entities2 context=new DbMyPortfolioNight_3Entities2();

       // public object Experianceİd { get; private set; }

        public ActionResult ExperienceList()
        {
            var values=context.Experience.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateExperience() 
        {
            return View();
        }


        [HttpPost]
        public ActionResult CreateExperience(Experience experience)
        {
            context.Experience.Add(experience);
            context.SaveChanges();

            return RedirectToAction("ExperienceList");
        }

        public ActionResult DeleteExperience(int id)
        {
            var value=context.Experience.Find(id);
            context.Experience.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            var value = context.Experience.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateExperience(Experience experience)
        {
            var value= context.Experience.Find(experience.Id);
            value.Title= experience.Title;
            value.SubTitle = experience.SubTitle;
            value.Description= experience.Description;
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}