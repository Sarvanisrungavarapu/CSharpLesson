using Microsoft.AspNetCore.Mvc;

namespace SecondMVCFile.Controllers
{
    public class SharedMovieController : Controller
    {
        public IActionResult Start()
        {
            return View();
        }
    }
}
