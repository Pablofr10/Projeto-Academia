using System.Collections.Generic;
using System.Threading.Tasks;
using Academia_API.Models;

namespace Academia_API.Data
{
    public interface IAcademiaRepository
    {
        Task<List<Pessoa>> GetTodos();
        Task<Pessoa> GetPorId(int id);
    }
}