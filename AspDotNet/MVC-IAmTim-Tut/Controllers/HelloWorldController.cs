using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVC_IAmTim_Tut.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name ="No value given", int numTimes =1) 
        {
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes = {numtimes}");
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}