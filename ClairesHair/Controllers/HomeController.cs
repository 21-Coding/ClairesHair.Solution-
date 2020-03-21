using Microsoft.AspNetCore.Mvc;

namespace Claire.Controllers
{
    public class HomeController : Controller
    {
    
        [HttpGet("/")]
        public ActionResult Index()
            {
                return View();
            }

    }   
}