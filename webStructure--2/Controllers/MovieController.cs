using Microsoft.AspNetCore.Mvc;

namespace webStructure.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult GetMovie (int id) {

            //ContentResult result= new ContentResult();

            //result.Content = $"Movies with id={id}";
            //return result;
            return Content($"Movie with id {id}","text/html");
        }

        [ActionName ("hamadaa")]
        [HttpPost]
        [AcceptVerbs("Get","Post")]
        public IActionResult Index()
        {
            //RedirectResult redirect = new RedirectResult("https://localhost:44395/Movie/GetMovie/10");

            //return redirect;
           // return RedirectToAction (nameof(GetMovie), new {id=10});
           return RedirectToRoute("default", new {controller= "Product",action="GetProduct",id=100});
        }
    }
}
