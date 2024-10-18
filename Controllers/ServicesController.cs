using PortfolyoProjectNight_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolyoProjectNight_2.Controllers
{
    public class ServicesController : Controller
    {
        DbMyPortfolioNight_3Entities2 context = new DbMyPortfolioNight_3Entities2();

        // GET: Services
        public ActionResult ServicesList()
        {
            var values=context.Service.ToList();
            return View(values);
        }
        public ActionResult DeleteServices(int id)
        {
            var values = context.Service.Find(id);
            context.Service.Remove(values);
            context.SaveChanges();
            return RedirectToAction("ServicesList");
        }

        [HttpGet]
        public ActionResult CreateServices()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateServices(Service service)
        {
            context.Service.Add(service);
            context.SaveChanges();
            return RedirectToAction("ServicesList");
        }

        [HttpGet]
        public ActionResult UpdateServices(int id)
        {
            var values = context.Service.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateServices(Service service)
        {
            var values = context.Service.Find(service.ServiceId);
            values.Title = service.Title;
            values.İcon = service.İcon;
            values.Description = service.Description;
            context.SaveChanges();
            return RedirectToAction("ServicesList");
        }

    }
}