﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html="<form method='post'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet me!' />" +
                "</form>";

            return Content(html, "text/html");
            //return Redirect("/Hello/Goodbye");
        }

        // /Hello
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "world")
        {
            return Content(string.Format("<h1>Hello {0}!</h1>", name),
            "text/html");
        }

        // Handle requests to /Hello/NAME (URL Segment) ex: /Hello/Chris
        [Route("/hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}!</h1>", name),
            "text/html");
        }

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
