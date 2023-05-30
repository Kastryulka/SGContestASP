using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using System.Diagnostics;
using testASPCoreMVC_2.Enums;
using testASPCoreMVC_2.Models;
using testASPCoreMVC_2.Utils;

namespace testASPCoreMVC_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        HomeIndexModel indexModel = new HomeIndexModel();
        APIHelper apiHelper = new APIHelper();
        FileHelper fileHelper = new FileHelper();

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
            indexModel.currentProblem = Int32.Parse(indexModel.tests[0].Variants.ElementAt(0).Key);
            indexModel.filePath = "F:\\SGContest-master\\PythonContestClient\\test.py";

            return View(indexModel);
        }

        [HttpPost]
        public async Task<IActionResult> Test(int currentProblem, String filePath, String studentNameInput, Languages LanguagesDD)
        {
            ViewBag.Message = "";
            //IFormFileCollection files = this.Request.Form.Files;
            String testId = Guid.NewGuid().ToString();
            String code = await fileHelper.readCodeAsync(filePath);
            String lang = "";
            switch (LanguagesDD)
            {
                case Languages.python:
                    {
                        lang = LanguagesDD.ToString();
                        break;
                    }
                case Languages.cs:
                    {
                        lang = "c#";
                        break;
                    }
                case Languages.c:
                    {
                        lang = LanguagesDD.ToString();
                        break;
                    }
                case Languages.cpp:
                    {
                        lang = "c++";
                        break;
                    }
                default: break;
            }
            var resp = await apiHelper.sendCodeToTestServerAsync(testId, studentNameInput, currentProblem, lang, "test", "1", code);
            Thread.Sleep(10000);

            String respResult = await apiHelper.getLastResultAsync(testId);
            ViewBag.Message = respResult;

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