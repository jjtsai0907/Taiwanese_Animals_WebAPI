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
                    EnglishName = "Formosan Mountain Dog",
                    LatinName = "Canis lupus familiaris",
                    Type = "Dog",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ8rNk9j66QYC8aHkepQJlikKq-cmo1n_4PBA&usqp=CAU"
                },
                new Animal {
                    Id = 2,
                    EnglishName = "Formosan Rock Macaque",
                    LatinName = "Macaca cyclopis",
                    Type = "Primate",
                    ImageURL = "https://static.wikia.nocookie.net/naturerules1/images/2/2f/03447c9e517de130892b8ac44356e91c.jpg/revision/latest/top-crop/width/360/height/450?cb=20210405160218"
                },
                new Animal {
                    Id = 3,
                    EnglishName = "Taiwan Blue Magpie",
                    LatinName = "Urocissa caerulea",
                    Type = "Monkey",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsYtUcptT8HcBzmTW4_EDFyDTUizaqdmJymA&usqp=CAU"
                },
                 new Animal {
                    Id = 4,
                    EnglishName = "Formosan Black Bear",
                    LatinName = "Ursus thibetanus formosanus",
                    Type = "Bear",
                    ImageURL = "https://live.staticflickr.com/2853/11775722235_19bb44c6e7_b.jpg"
                },
                new Animal {
                    Id = 5,
                    EnglishName = "Taiwan serow",
                    LatinName = "Capricornis swinhoei",
                    Type = "Bovid",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQhP0A9Lp4E6dZ_D4vjrPc2in3Fnr5Rf6Kn0g&usqp=CAU"
                },
            };
        }

    }
}
