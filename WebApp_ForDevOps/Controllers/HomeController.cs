using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp_ForDevOps.Models;
using WebApp_ForDevOps.ViewModels;

namespace WebApp_ForDevOps.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMyMathService mathService;
        private readonly Random random;
        public HomeController(ILogger<HomeController> logger, IMyMathService mathService)
        {
            _logger = logger;
            this.mathService = mathService;
            random = new Random();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        #region Add
        public IActionResult Add()
        {
            AddOperationRequest request = new AddOperationRequest();
            request.NumberOne = random.Next(1, 6000);
            request.NumberTwo = random.Next(1, 6000);
            return View(request);
        }

        [HttpPost]
        public IActionResult Add(AddOperationRequest request)
        {
            var result = mathService.Add(request.NumberOne, request.NumberTwo);
            request.Result = result;
            return View(request);
        }
        #endregion

        #region Raise
        public IActionResult Raise()
        {
            RaiseOperationRequest request = new RaiseOperationRequest();
            request.NumberBase = random.Next(1, 6000);
            request.NumberExponent = random.Next(1, 5);
            return View(request);
        }

        [HttpPost]
        public IActionResult Raise(RaiseOperationRequest request)
        {
            var result = mathService.Raise(request.NumberBase, request.NumberExponent);
            request.Result = result;
            return View(request);
        }
        #endregion

        #region Half
        public IActionResult Half()
        {
            HalfOperationRequest request = new HalfOperationRequest();
            request.Number = random.Next(2, 6000);
            return View(request);
        }
        [HttpPost]
        public IActionResult Half(HalfOperationRequest request)
        {
            var result = mathService.Half(request.Number);
            request.Result = result;
            return View(request);
        }
        #endregion


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}