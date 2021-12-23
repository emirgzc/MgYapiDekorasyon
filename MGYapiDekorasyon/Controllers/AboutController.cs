using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MGYapiDekorasyon.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager(new EfAboutDal());
        public ActionResult AboutIndex()
        {
            var aboutList = abm.GetAll();
            return View(aboutList);
        }
    }
}