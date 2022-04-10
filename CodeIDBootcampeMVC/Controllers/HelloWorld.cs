using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace CodeIDBootcampeMVC.Controllers
{
    public class HelloWorld : Controller
    {
        public string Index()
        {
            return "Hello World";
        }

        public string Welcome(string name = "nyai")
        {
            return "Welcome " + name;
        }

        public string Profile(string name, int id)
        {
            return HtmlEncoder.Default.Encode($"Profile for: {name} Id: {id}");
        }

        public string addtion(int a, int b)
        {
            return "a + b = " + ( a + b);
        }
    }
}
