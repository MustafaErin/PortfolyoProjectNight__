using PortfolyoProjectNight_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolyoProjectNight_2.Controllers
{
    public class MessageController : Controller
    {
       DbMyPortfolioNight_3Entities2 context=new DbMyPortfolioNight_3Entities2();
        public ActionResult İnbox()
        {
            var values=context.Contact.ToList();
            return View(values);
        }

        public ActionResult ChangeMessageStatusToTrue(int id)
        {
            var value=context.Contact.Find(id);
            value.İsRead = true;
            context.SaveChanges();
            return RedirectToAction("İnbox");
        }
        public ActionResult ChangeMessageStatusToFalse(int id)
        {
            var value = context.Contact.Find(id);
            value.İsRead = false;
            context.SaveChanges();
            return RedirectToAction("İnbox");
        }
        public ActionResult DeleteMessage(int id)
        {
            var value=context.Contact.Find(id);
            context.Contact.Remove(value);
            context.SaveChanges();
            return RedirectToAction("İnbox");
        }

    }
}