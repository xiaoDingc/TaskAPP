using System.Web.Mvc;

namespace SimpleTaskSystem.Web.Controllers
{
    public class HomeController : SimpleTaskSystemControllerBase
    {
        private ITaskAppService _appService;
        public HomeController(ITaskAppService appService)
        {
            _appService = appService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            GetTasksInput getTasksInput = new GetTasksInput();
            getTasksInput.TaskId = 1;
            GetTasksOutput res = _appService.GetTasks(getTasksInput);

            return View(res.Tasks);
        }
    }
}