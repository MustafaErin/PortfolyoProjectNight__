using Microsoft.SqlServer.Server;
using PortfolyoProjectNight_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using System.Collections;
using System.Web.Helpers;
using Microsoft.Ajax.Utilities;

namespace PortfolyoProjectNight_2.Controllers
{
    public class SkillController : Controller
    {
        DbMyPortfolioNight_3Entities2 context = new DbMyPortfolioNight_3Entities2();
        public ActionResult SkillList(int sayfa=1 )
        {
            var values = context.Skill.ToList().ToPagedList(sayfa, 5);
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSkill(Skill skill)
        {
            context.Skill.Add(skill);
            context.SaveChanges();

            return RedirectToAction("SkillList");
        }

        public ActionResult DeleteSkill(int id)
        {
            var value= context.Skill.Find(id);
            context.Skill.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value=context.Skill.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSkill(Skill skill)
        {
            var value = context.Skill.Find(skill.SkillId);
            value.SkillName = skill.SkillName;
            value.Rate = skill.Rate;
            value.Status = skill.Status;
            value.Icon= skill.Icon;
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        public ActionResult SkillValues()
        {
            return View();
        }
       

    }
}