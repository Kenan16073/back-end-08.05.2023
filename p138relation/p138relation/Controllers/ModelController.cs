using Microsoft.AspNetCore.Mvc;
using p138relation.Models;

namespace p138relation.Controllers
{
    public class ModelController : Controller
    {

        private readonly List<model> _model;

        public ModelController()
        {
            _model = new List<model>
            {
                new model {Id=1,Name="bmw",MarkaId="m5"}

            };
        }


        public IActionResult Index(int? id )
        {
            if(id !=null)
            {
                if (!_model.Exists(m => m.Id == id))
                {
                    return BadRequest();
                }
                return View(_model.FindAll(m => m.Id == id));
            }

            return View(_model);
        }

        
    }
}
