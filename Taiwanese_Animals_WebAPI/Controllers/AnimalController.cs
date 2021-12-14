using Microsoft.AspNetCore.Mvc;
using Taiwanese_Animals_WebAPI.Entities;
using Taiwanese_Animals_WebAPI.Repo;

namespace Taiwanese_Animals_WebAPI.Controllers
{
    [ApiController]
    [Route("api/taiwanese_animal")]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalRepo _repo;

        public AnimalController(IAnimalRepo repo)
        {
            _repo = repo;
        }


        // GET /api/taiwanese_animal
        [HttpGet("")]
        //public List<Animal> GetAnimals()
        public IActionResult GetAnimals()
        {
            List<Animal> animals = _repo.GetAll();
            return Ok(animals);
        }

        // GET /api/taiwanese_animal/:id
        [HttpGet("{id}")]
        //public Animal GetAnimalByID(int id)
        public IActionResult GetAnimalByID(int id)
        {
            Animal animal = _repo.GetById(id);
            if (animal is null)
            {
                return NotFound("Sorry, we cannot find an animal with id " + id);
            }
            return Ok(animal);
        }

        [HttpPost("")]
        //public Animal CreateAnimal([FromBody]Animal animal)
        public IActionResult CreateAnimal([FromBody] Animal animal)
        {
            Animal createdAnimal = _repo.CreateAnimal(animal);
            return CreatedAtAction(
                nameof(GetAnimalByID),
                new { id = createdAnimal.Id},
                createdAnimal
                ); 
                
        }

        // PUT /api/taiwanese_animal/:id
        [HttpPut("{id}")]
        //public Animal UpdateAnimal([FromBody] Animal animal)
        public IActionResult UpdateAnimal([FromBody] Animal animal)
        {
            Animal updatedAnimal = _repo.UpdateAnimal(animal);
            return Ok(updatedAnimal);
        }


        [HttpDelete("{id}")]
        //public void DeleteAnimal(int id)
        public IActionResult DeleteAnimal(int id)
        {
             _repo.DeleteAnimal(id);
            return NoContent();
        }

    }
}
