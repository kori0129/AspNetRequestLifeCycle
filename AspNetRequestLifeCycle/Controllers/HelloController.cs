using System.Diagnostics;
using AspNetRequestLifeCycle.ActionFilters;
using AspNetRequestLifeCycle.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetRequestLifeCycle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        public HelloController(IService1 service1, IService2 service2)
        {
            Debug.WriteLine("HelloController constructor");
        }

        [WarningFilter("Info")]
        [HttpGet("main")]
        public IActionResult Main()
        {
            Debug.WriteLine("Main Action Running");
            
            return Content("Hello");
        }

        [HttpGet("data")]
        public ActionResult<List<string>> Data()
        {
            List<string> data = new List<string>();
            data.Add("item 1");
            data.Add("item 2");
            data.Add("item 3");
            return data;
        }
    }
}
