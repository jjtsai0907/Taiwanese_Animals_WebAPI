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
        public List<Animal> GetAnimals()
        {
            List<Animal> animals = _repo.GetAll();
            return animals;
        }

        // GET /api/taiwanese_animal/:id
        [HttpGet("{id}")]
        public Animal GetAnimalByID(int id)
        {
            return _repo.GetById(id);
        }

        [HttpPost("")]
        public Animal CreateAnimal([FromBody]Animal animal)
        {
            Animal createdAnimal = _repo.CreateAnimal(animal);
            return createdAnimal;
        }

        // PUT /api/taiwanese_animal/:id
        [HttpPut("{id}")]
        public Animal UpdateAnimal([FromBody] Animal animal)
        {
            Animal updatedAnimal = _repo.UpdateAnimal(animal);
            return updatedAnimal;
        }


        [HttpDelete("{id}")]
        public void DeleteAnimal(int id)
        {
             _repo.DeleteAnimal(id);
        }

    }
}
