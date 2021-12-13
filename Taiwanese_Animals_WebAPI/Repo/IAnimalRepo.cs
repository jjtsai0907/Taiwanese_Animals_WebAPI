using Taiwanese_Animals_WebAPI.Entities;

namespace Taiwanese_Animals_WebAPI.Repo
{
    public interface IAnimalRepo
    {
        List<Animal> GetAll();

        Animal GetById(int id);

        

    }
}
