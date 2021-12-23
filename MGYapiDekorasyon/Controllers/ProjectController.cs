using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MGYapiDekorasyon.Controllers
{
    public class ProjectController : Controller
    {
        ProjectManager pm = new ProjectManager(new EfProjectDal());
        public ActionResult ProjectIndex()
        {
            var projectList = pm.GetAll();
            return View(projectList);
        }
    }
}