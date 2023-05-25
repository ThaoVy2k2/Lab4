using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {//public IActionResult Index()
	 //{
	 // return View();
	 //}
	 // 
	 // GET: /HelloWorld/
		public IActionResult HelloWorld(string name, int numTimes = 1)
		{
			ViewData["Message"] = "Hello " + name;
			ViewData["NumTimes"] = numTimes;
			return View();
		}

		// 
		// GET: /HelloWorld/Welcome/ 
		public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}

