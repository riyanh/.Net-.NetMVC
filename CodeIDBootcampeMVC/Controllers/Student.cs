using Microsoft.AspNetCore.Mvc;

namespace CodeIDBootcampeMVC.Controllers
{
    public class Student : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Class(int roomNumber, string floor)
        {
            ViewData["param1"] = "You are in : " + roomNumber;
            ViewData["param2"] = "At floor : " + floor;
            return View();
        }

        public IActionResult Exam(string topics)
        {
            ViewData["message"] = "Exam topic : " + topics;
            return View();
        }

        public IActionResult Profile(string name, int age, string address)
        {
            ViewData["par1"] = "Name : " + name;
            ViewData["par2"] = "age : " + age;
            ViewData["par3"] = "Address : " + address;
            return View();
        }
    }
}
