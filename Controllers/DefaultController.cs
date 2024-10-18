using PortfolyoProjectNight_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace PortfolyoProjectNight_2.Controllers
{
    public class DefaultController : Controller
    {
        DbMyPortfolioNight_3Entities2 context = new DbMyPortfolioNight_3Entities2();

        public ActionResult Index()
        {
            List<SelectListItem> values = (from x in context.Category.ToList() 
                                           select new SelectListItem
                                           {
                                               Text=x.CategoryName,
                                               Value=x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v=values;
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            contact.SandDate= DateTime.Parse(DateTime.Now.ToShortDateString());
            contact.İsRead = false;

            context.Contact.Add(contact);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialHeader()
        {
            ViewBag.title = context.Profile.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = context.Profile.Select(x => x.Description).FirstOrDefault();
            ViewBag.address = context.Profile.Select(x => x.Address).FirstOrDefault();
            ViewBag.Email = context.Profile.Select(x => x.email).FirstOrDefault();
            ViewBag.telephone = context.Profile.Select(x => x.Phone).FirstOrDefault();
            ViewBag.github = context.Profile.Select(x => x.Github).FirstOrDefault();
            ViewBag.url = context.Profile.Select(x => x.İmgUrl).FirstOrDefault();

            return PartialView();

        }
        public PartialViewResult PartialAbout()
        {
            var values = context.About.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialEducation()
        {

            var value = context.Education.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialExperience()
        {
            var values = context.Experience.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = context.Skill.Where(x => x.Status == true).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partialİntern()
        {

            var value = context.İntern.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialServices()
        {
            var value = context.Service.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialPortfolio()
        {
            ViewBag.Description3 = context.Experience.Where(x => x.Id == 2003).Select(y => y.Description).FirstOrDefault();
            ViewBag.SubTitle3 = context.Experience.Where(x => x.Id == 2003).Select(y => y.SubTitle).FirstOrDefault();
            ViewBag.Title3 = context.Experience.Where(x => x.Id == 2003).Select(y => y.Title).FirstOrDefault();

            ViewBag.Description2 = context.Experience.Where(x => x.Id == 2002).Select(y => y.Description).FirstOrDefault();
            ViewBag.SubTitle2 = context.Experience.Where(x => x.Id == 2002).Select(y => y.SubTitle).FirstOrDefault();
            ViewBag.Title2 = context.Experience.Where(x => x.Id == 2002).Select(y => y.Title).FirstOrDefault();

            ViewBag.Description1 = context.Experience.Where(x => x.Id == 1).Select(y => y.Description).FirstOrDefault();
            ViewBag.SubTitle1 = context.Experience.Where(x => x.Id == 1).Select(y => y.SubTitle).FirstOrDefault();
            ViewBag.Title1 = context.Experience.Where(x => x.Id == 1).Select(y => y.Title).FirstOrDefault();

            return PartialView();

        }
        public PartialViewResult PartialTestimonial()
        {

            var value = context.Testimonia.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialFooter()
        {

            return PartialView();
        }
    }
}