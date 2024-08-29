using Microsoft.AspNetCore.Mvc;

namespace MVC02.Controllers
{
    public class MovieController : Controller
    {
        // Action => public non-static func 
        public IActionResult GetMovie(int id)
        {
            //ContentResult contentResult = new ContentResult();
            //contentResult.Content = $"Movie with id = {id}";
            //contentResult.ContentType = "text/html";
            //contentResult.StatusCode = 200;
            return Content($"Movie with id = {id}", "text/html");
            //return $"New Movie";
        }
        [ActionName ("hamada")]
        [HttpGet]
        [AcceptVerbs("Post", "Get", "Patch")]
        public IActionResult index()
        {
            //RedirectResult redirectResult = new RedirectResult("https://localhost:44305/movie/GetMovie/10");
            //return redirectResult;
            //return Redirect("{baseUrl}/movie/GetMovie/10");
            //return RedirectToAction(nameof(GetMovie), new {id = 10});
            return RedirectToRoute("default", new { controller = "Product", action = "GetProduct", id = 10 });
        }

        public IActionResult viewResult()
        {
            return View();
        }
    }
}
