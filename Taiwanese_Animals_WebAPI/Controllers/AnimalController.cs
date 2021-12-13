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



    }
}
