using System.Linq;
using System.Web.Mvc;
using NWT.DAL;

namespace NWT.Controllers
{
    public class CoursesController : Controller
    {
        private NWTContext db = new NWTContext();

        // GET: Courses
        public ActionResult Index()
        {
            return View("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
