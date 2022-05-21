using ASP___Web_API___IAction_Resulte_HWS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP___Web_API___IAction_Resulte_HWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        public List<Animal> Animals { get; set; } = new List<Animal>()
        {
            new Animal(){Name = "cat" , Age = 8},
            new Animal(){Name = "dog" , Age = 4},
            new Animal(){Name = "fox" , Age = 5},
            new Animal(){Name = "bird" , Age = 2},
            new Animal(){Name = "giraffe" , Age = 9},
        };

        [HttpGet("{name}")]
        public IActionResult GetById(string name)
        {
            Animal animal = Animals.Find(animal => animal.Name == name);
            if (animal == null)
            {
                return NotFound("animal dont exist on the list...");
            }
            if(animal.Name == "giraffe")
            {
                return LocalRedirect("~/api/animal/smile");
            }
            return Ok(animal);
          
        }

        [HttpGet("spacial/{name}")]
        public ActionResult<Animal> GetAnimal(string name)
        {
            Animal animal = Animals.Find(animal => animal.Name == name);
            if (animal == null)
            {
                return NotFound("animal dont exist on the list...");
            }
            if (animal.Name == "giraffe")
            {
                return LocalRedirect("~/api/animal/smile");
            }
            return animal;

        }

        [Route("smile")]
        public IActionResult GetSmile()
        {
            return Ok(":)");
        }
    }
}
