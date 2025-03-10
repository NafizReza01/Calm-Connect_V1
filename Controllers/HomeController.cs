using CalmnConnect;
using Microsoft.AspNetCore.Mvc;
using static CalmnConnect.MLModel;
using Microsoft.ML;
using Microsoft.ML.Data;


namespace CalmAndConnect.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Doctors()
        {
            return View();
        }

        public IActionResult Blogs()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult WriteBlog()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Predict()
        {
            return View();
        }

        /*[HttpPost]
        public IActionResult Predict(ModelInput input)
        {
            object ConsumeModel = null;
            ModelOutput result = ConsumeModel.Predict(input);
            ViewBag.Result = result;

       
            return View();
        }
        */



        public HomeController()
        {
        }

        public object Result
        {
            get
            {
                return Result1;
            }
            set => Result1 = value;
        }
        public object Result1 { get; private set; }

    }
}
