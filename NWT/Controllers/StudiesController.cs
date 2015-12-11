using System.Linq;
using System.Web.Mvc;
using NWT.DAL;

namespace NWT.Controllers
{
    public class StudiesController : Controller
    {
        private NWTContext db = new NWTContext();

        // GET: Studies
        public ActionResult Index()
        {
            return View(db.Studies.ToList());
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
