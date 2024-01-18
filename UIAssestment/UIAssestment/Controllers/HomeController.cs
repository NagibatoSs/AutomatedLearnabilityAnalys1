using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UIAssestment.Assest;
using UIAssestment.Models;
using UIAssestment.TextReading;

namespace UIAssestment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHost;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment webHost)
        {
            _logger = logger;
            _webHost = webHost;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(List<IFormFile> UploadedFiles)
        {
            string uploadFolder = Path.Combine(_webHost.WebRootPath, "Files");
            if (!Directory.Exists(uploadFolder))
            {
                Directory.CreateDirectory(uploadFolder);
            }

            foreach (var uploadedFile in UploadedFiles)
            {
                string fileName = Path.GetFileName(uploadedFile.FileName);
                string fileSavePath = Path.Combine(uploadFolder, fileName);
                using (FileStream stream = new FileStream(fileSavePath, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(stream);
                }
                var assess = new ControlElementsAssessment();
                assess.Process();
                ViewBag.Message = String.Format("Rate = {0}, Message = {1}", assess.Rate, assess.RateMessage);
            }
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
