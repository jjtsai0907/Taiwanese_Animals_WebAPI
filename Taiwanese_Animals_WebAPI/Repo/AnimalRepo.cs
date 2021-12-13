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


        public List<Animal> GetAll()
        {
            throw new NotImplementedException();
        }

        public Animal GetById(int id)
        {
            throw new NotImplementedException();
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
