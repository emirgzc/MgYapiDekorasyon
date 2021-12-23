using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MGYapiDekorasyon.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        SettingsManager sm = new SettingsManager(new EfSettingsDal());
        [HttpGet]
        public ActionResult Index()
        {
            var setList = sm.GetAll();
            return View(setList);
        }
        [HttpPost]
        public ActionResult Index(Contact c)
        {
            return View();
        }
    }
}