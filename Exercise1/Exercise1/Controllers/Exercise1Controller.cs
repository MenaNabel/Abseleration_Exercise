using Exercise1.ViewModels;
using System.Web.Mvc;

namespace Exercise1.Controllers
{
    public class Exercise1Controller : Controller
    {
        // GET: EX
        public ActionResult Index()
        {
            return View("Index", new HelloWorldCppViewModel());
        }
        public ActionResult Run()
        {
            return View("Index", new HelloWorldCppViewModel()
            {  ServerMessage = "Hello World!" });
        }
    }
}