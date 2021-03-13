using Exercise1.Cpp;
using Exercise1.ViewModels;
using System.Threading.Tasks;
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
            string path =  CompilerCpp.CompileCppFile(Generator.GenerateCppFile());
            return View("Index", new HelloWorldCppViewModel()
            {  ServerMessage = ProgramRunner.RunProgram(path) });
        }
    }
}