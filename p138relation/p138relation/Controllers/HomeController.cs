using Microsoft.AspNetCore.Mvc;
using p138relation.Models;

namespace p138relation.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Marka> _marka;

        public HomeController()
        {
            _marka = new List<Marka>
            {
                new Marka {Id=1,Name="bmw"},

            };
        }


        public IActionResult Index()
        {
            return View(_marka);
        }
    }
}
