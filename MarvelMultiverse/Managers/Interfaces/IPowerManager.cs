using MarvelMultiverse.Models;

namespace MarvelMultiverse.Managers;

public interface IPowerManager
{
    List<Power> GetAll();

    List<string> GetAllNames();

    Power Get(string name);

    List<Power> GetAllByPowerSet(string name);
    
    List<string> GetAllNamesByPowerSet(string name);
}
