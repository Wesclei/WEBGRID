using System.Linq;
using System.Web.Mvc;
using WEBGRID.Models;

namespace WEBGRID.Controllers
{
    public class EmployeesController : Controller
    {
        private WEBGRIDContext db = new WEBGRIDContext();

        // GET: Employees
        public ActionResult Index()
        {
            using (var context = new WEBGRIDContext())
            {
                //string firstname = "Billy";
                //var data = context.Employees.SqlQuery("SELECT * FROM dbo.Employees").ToList();
                var data = context.Employees.SqlQuery("[dbo].[SelectAllEmployee]").ToList();
                return View(data);
            }                
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
