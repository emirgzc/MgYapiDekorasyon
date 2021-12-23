using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MGYapiDekorasyon.Controllers
{
    public class AnaController : Controller
    {
        SettingsManager sm = new SettingsManager(new EfSettingsDal());
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Footer()
		{
            return PartialView();
		}
        public PartialViewResult TopBar()
		{
            var topList = sm.GetAll();
            return PartialView(topList);
		}
    }
}