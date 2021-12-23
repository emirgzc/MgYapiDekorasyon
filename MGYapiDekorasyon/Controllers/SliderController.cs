using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MGYapiDekorasyon.Controllers
{
    public class SliderController : Controller
    {
        SliderManager sm = new SliderManager(new EfSliderDal());
        public PartialViewResult AnaSlider()
        {
            var sliderList = sm.GetAll();
            return PartialView(sliderList);
        }
    }
}