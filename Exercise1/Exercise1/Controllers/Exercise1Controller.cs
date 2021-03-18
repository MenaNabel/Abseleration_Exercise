using Exercise1.Cpp;
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
            string path = Generator.GenerateCppFile();
            string compilePath = CompilerCpp.CompileCppFile(path);
            string word = ProgramRunner.RunProgram(compilePath);
            return View("Index", new HelloWorldCppViewModel()
            { ServerMessage = word }) ;
        }
    }
}