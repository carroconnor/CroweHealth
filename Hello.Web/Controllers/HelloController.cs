using System.Web.Mvc;
using Hello.Models;

namespace Hello.Web.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HelloCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            ModelState.AddModelError("", "Could not say Hello World");

            return View(model);
        }

        // Determine where to write to db with Inheritance
        //public void WriteMethod()
        //{
        //    var writeMode = WebConfigurationManager.AppSettings["writeDestination"];
        //    switch (writeMode)
        //    {
        //        case "output":
        //            writer = new Writer();
        //            break;
        //        case "db":
        //            writer = new DbWriter();
        //            break;
        //        case "process":
        //            writer = new ProcessWriter();
        //            break;
        //    }
        //}
    }

}