using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolyoProjectNight_2.Models;

namespace PortfolyoProjectNight_2.Controllers
{
    public class StatisticsController : Controller
    {
       DbMyPortfolioNight_3Entities2 context=new DbMyPortfolioNight_3Entities2();

        public ActionResult Index()
        {
            ViewBag.totalMessageCount=context.Contact.Count();
            ViewBag.isReadTrueCount = context.Contact.Where(x => x.İsRead == true).Count();
            ViewBag.isReadFalseCount = context.Contact.Where(y => y.İsRead == false).Count();
            ViewBag.skillCount=context.Skill.Count();
            ViewBag.skillRateSum = context.Skill.Sum(x => x.Rate);
            ViewBag.skillRateAvarage = context.Skill.Average(x => x.Rate);

            var maxRate=context.Skill.Max(x => x.Rate);
            ViewBag.maxRateSkillName=context.Skill.Where(x=>x.Rate==maxRate).Select(y=>y.SkillName).FirstOrDefault();

            ViewBag.getMessageCountBySubjectReferance=context.Contact.Where(x=>x.Message=="test").Count();
            ViewBag.getMessageCountByEmailContainWAndİsReadTrue = context.Contact.Where(x => x.İsRead == true && x.Email.Contains("w")).Count();
            ViewBag.getSkillNameByRate90=context.Skill.Where(x=>x.Rate==90).Select(y=>y.SkillName).FirstOrDefault();
            
            return View();
        }
    }
}