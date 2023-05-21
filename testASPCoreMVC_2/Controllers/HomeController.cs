using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using testASPCoreMVC_2.Models;
using testASPCoreMVC_2.Utils;

namespace testASPCoreMVC_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        HomeIndexModel indexModel = new HomeIndexModel();
        APIHelper apiHelper = new APIHelper();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            return View(indexModel);
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignOut()
        {
            return Redirect("~/");
        }
        [HttpPost]
        public async Task<IActionResult> IndexAsync(string studentNameInput)
        {            
            var resp = await apiHelper.getOneUserAsync(studentNameInput);
            var userJson = System.Text.Json.JsonSerializer.Deserialize<UserJson>(resp);
            var user = userJson.getUser();
            indexModel.User = user.UserName;
            indexModel.tests = user.Data.Tests.ToList();

            return View(indexModel);
        }
        [HttpPost]
        public async Task<IActionResult> Test(int currentProblem)
        {
            ViewBag.Message = "";

            return View();
        }
        protected IActionResult ProblemChanged(object sender) { ViewBag.Message = "123123"; return View(); }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}