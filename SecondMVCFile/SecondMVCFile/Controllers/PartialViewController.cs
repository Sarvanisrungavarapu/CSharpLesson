using Microsoft.AspNetCore.Mvc;

namespace SecondMVCFile.Controllers
{
    public class PartialViewController : Controller
    {
        //GET:PartialView
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tabs() 
        {
            ViewData["data1"] = "Tom And Jerry are Good Friends";
            return View();
        }
    }
}
