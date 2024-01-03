using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetRequestLifeCycle.Controllers
{
    public class HelloConventionController : Controller
    {
        public IActionResult Main()
        {
            return Content("Hello Convention!");
        }

        public IActionResult Index()
        {
            return Content("Hello Index Convention");
        }


    }
}
