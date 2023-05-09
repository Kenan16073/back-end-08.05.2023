using Microsoft.AspNetCore.Mvc;
using p138relation.Models;

namespace p138relation.Controllers
{
    public class CarController : Controller

    {

        private readonly List<car> _car;
        
        public CarController()
        {
            _car = new List<car>
            {
                new car {Id=1,Name="bmw",price=20000,ModelId=1},
                
            };
        }


        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                return BadRequest();
            }
            car car = _car.Find(m => m.Id == id);


            if (car == null)
            {
                return NotFound();
            }
            return View();
        }


    }
}
