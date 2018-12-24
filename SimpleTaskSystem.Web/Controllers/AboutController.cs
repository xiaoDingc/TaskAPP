using System.Web.Mvc;

namespace SimpleTaskSystem.Web.Controllers
{
    public class AboutController : SimpleTaskSystemControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}