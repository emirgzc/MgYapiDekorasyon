using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MGYapiDekorasyon.Controllers
{
    public class ServicesController : Controller
    {
        ServiceManager sm = new ServiceManager(new EfServicesDal());
        public ActionResult ServicesIndex()
        {
            var servicesList = sm.GetStatusByTrue();
            return View(servicesList);
        }
        public ActionResult ServicesDetails(int id)
        {
            var servicesList = sm.GetServicesById(id);
            return View(servicesList);
        }
        public PartialViewResult ServicesTitleList()
		{
            var servicesListTitle = sm.GetAll();
            return PartialView(servicesListTitle);
		}
    }
}