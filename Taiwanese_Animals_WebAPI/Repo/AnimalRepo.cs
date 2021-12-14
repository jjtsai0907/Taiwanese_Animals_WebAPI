using Taiwanese_Animals_WebAPI.Entities;

namespace Taiwanese_Animals_WebAPI.Repo
{
    public class AnimalRepo : IAnimalRepo
    {

        private List<Animal> _animals;

        public AnimalRepo()
        {
            _animals = PopulateAnimalData();
        }

        public Animal CreateAnimal(Animal animal)
        {
            animal.Id = _animals.Max(x => x.Id) + 1;

            _animals.Add(animal);
            return animal;
        }

        public void DeleteAnimal(int id)
        {
            _animals.Remove(GetById(id));
        }

        public List<Animal> GetAll()
        {
            return _animals;
        }

        public Animal GetById(int id)
        {
            // Find method is good for searching by ID; If it doesn't find it, it returns null
            Animal animal = _animals.Find(x => x.Id == id);
            return animal;
        }

        public Animal UpdateAnimal(Animal animal)
        {
            // Find the one first
            Animal existingAnimal = _animals.FirstOrDefault(x => x.Id == animal.Id);
            if (existingAnimal is not null)
            {
                existingAnimal.EnglishName = animal.EnglishName;
                existingAnimal.LatinName = animal.LatinName;
                existingAnimal.Type = animal.Type;
            }
            return existingAnimal;
        }

        private List<Animal> PopulateAnimalData()
        {
            return new List<Animal>
            {
                new Animal {
                    Id = 1,
                    EnglishName = "1",
                    LatinName = "",
                    Type = ""
                },
                new Animal {
                    Id = 2,
                    EnglishName = "2",
                    LatinName = "",
                    Type = ""
                },
                new Animal {
                    Id = 3,
                    EnglishName = "3",
                    LatinName = "",
                    Type = ""
                },
            };
        }

    }
}
