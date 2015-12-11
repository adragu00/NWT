using System.Web.Mvc;
using NWT.DAL;

namespace NWT.Controllers
{
    public class SubjectsController : Controller
    {
        private NWTContext db = new NWTContext();

        // GET: Subjects
        public ActionResult Index()
        {
            return View();
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
