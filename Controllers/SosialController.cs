using PortfolyoProjectNight_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolyoProjectNight_2.Controllers
{
    public class SosialController : Controller
    {
        DbMyPortfolioNight_3Entities2 context = new DbMyPortfolioNight_3Entities2();
        // GET: Sosial
        public ActionResult ListSosial()
        {
            var value = context.SosialMedia.ToList();
            return View(value);
        }
        public ActionResult DeleteSosial(int id)
        {
            var value = context.SosialMedia.Find(id);
            context.SosialMedia.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ListSosial");
        }
        [HttpGet]
        public ActionResult CreateSosial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSosial(SosialMedia sosialMedia)
        {
            var value = context.SosialMedia.Add(sosialMedia);
            context.SaveChanges();
            return RedirectToAction("ListSosial");
        }
        [HttpGet]
        public ActionResult UpdateSosial(int id)
        {
            var value = context.SosialMedia.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSosial(SosialMedia sosialMedia)
        {
            var value = context.SosialMedia.Find(sosialMedia.SosialMediaId);
            value.Title = sosialMedia.Title;
            value.Url = sosialMedia.Url;
            value.İcon = sosialMedia.İcon;
            value.Status = sosialMedia.Status;
            context.SaveChanges();
            return RedirectToAction("ListSosial");
        }
        public ActionResult ToTrue(int id)
        {
            var value = context.SosialMedia.Find(id);
            value.Status = true;
            context.SaveChanges();
            return RedirectToAction("ListSosial");
        }

        public ActionResult ToFalse(int id)
        {
            var value = context.SosialMedia.Find(id);
            value.Status = false;
            context.SaveChanges();
            return RedirectToAction("ListSosial");
        }



    }
}