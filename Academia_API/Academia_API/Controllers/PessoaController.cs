using System.Collections.Generic;
using System.Threading.Tasks;
using Academia_API.Data;
using Academia_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academia_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IAcademiaRepository _repo;

        public PessoaController(IAcademiaRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IEnumerable<Pessoa>> GetTodos()
        {
            return await _repo.GetTodos();
        }

        [HttpGet("{id}")]
        public async Task<Pessoa> GetPorId(int id)
        {
            return await _repo.GetPorId(id);
        }
    }
}