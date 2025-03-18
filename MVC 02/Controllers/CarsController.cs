using Microsoft.AspNetCore.Mvc;

namespace MVC_02.Controllers
{
    public class CarsController : Controller
    {
        public string Index()
        {
            return "I'm in Index!";
        }


        // baseURL/Cars/GetCar/Id
        [HttpGet]
        public ContentResult GetCar(int? Id)
        {
            var r = new ContentResult();
            r.Content = $"MY </br> ID = {Id}";
            r.ContentType = "text/html";
            return r;
        }

        // baseURL/Cars/GetCarByname?name=BMW
        [HttpGet]
        public IActionResult GetCarByname(string name)
        {
            if (name == null)
            {
                return NotFound();
            }else if (name.Length < 5)
            {
                return BadRequest();
            }

            return Content($"MY </br> Name = {name}" ,contentType:"text/html");
        }

        [HttpPost]
        public IActionResult GetCarrr(int Id ,Car car , string Title)
         {
            return Content(content:$"{car.Id}</br>{car.Title}" , contentType:"text/html");
        }


        public IActionResult Home()
        {
            return View("FirstView");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
    }

    public class Car
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }


}
