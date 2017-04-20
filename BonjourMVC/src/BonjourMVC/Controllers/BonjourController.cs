using Microsoft.AspNetCore.Mvc;
using System.Text;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BonjourMVC.Controllers
{
    public class BonjourController : Controller
    {
        [HttpGet]
        [Route("/bonjour")]
        public IActionResult GetHelloForm()
        {
            StringBuilder html = new StringBuilder();
            html.Append("<form method='post'>")
                .Append("<input type='text' name='name' value='Anonymous' />")
                .Append("<select name='language' />");

            // append an option for each language in the dictionary
            foreach (string language in HelloMessage.GetLanguages())
            {
                html.Append(string.Format("<option value='{0}'>{0}</option>", language));
            };
            
            html.Append("</select>")
                .Append("<input type='submit' value='Greet me!' />")
                .Append("</form>");

            return Content(html.ToString(), "text/html");
        }

        [Route("/bonjour")]
        [HttpPost]
        public IActionResult PostBonjourForm(string language= "English", string name = "Anonymous")
        {
            //get the greeting cookie and increment
            string cookieName = "greetings";
            int greetingCount = 0;
            string cookieCount;
            if (Request.Cookies.TryGetValue(cookieName, out cookieCount))
            {
                greetingCount = int.Parse(cookieCount);
            }
            greetingCount += 1;

            // build the html response
            StringBuilder html = new StringBuilder();
            html.Append("<h1 style ='color:red;font-family:Arial;' />")
                .Append(HelloMessage.CreateMessage(language, name))
                .Append(string.Format("<h2>{0} total greetings have been generated!</h2>", greetingCount))
                .Append("</h1>");

            // set the greetings cookie
            Response.Cookies.Append(cookieName, greetingCount.ToString());

            return Content(html.ToString(), "text/html");
        }

        // Handle requests to /Hello/NAME (URL Segment) ex: /Hello/Chris
        [Route("/bonjour/{name}")]
        public IActionResult PostBonjourForm2(string language = "English", string name = "Anonymous")
        {
            return Content(HelloMessage.CreateMessage(language, name), "text/html");
        }

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
