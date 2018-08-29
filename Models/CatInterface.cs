using System.Collections.Generic;
using System.Threading.Tasks;

namespace myFirstProject.Models
{
    public interface CatInterface
    {
        Task<IEnumerable<Cat>> GetAll(); // for all cats list
        Task insertCat(Cat item);
        Task<bool> RemoveCat(string name);
        Task<bool> UpdateCat(string id, string name);
    }
}
