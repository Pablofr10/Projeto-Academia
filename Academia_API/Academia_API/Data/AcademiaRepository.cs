using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academia_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Academia_API.Data
{
    public class AcademiaRepository : IAcademiaRepository
    {
        private readonly DataContext _context;

        public AcademiaRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Pessoa>> GetTodos()
        {
            IQueryable<Pessoa> query = _context.Pessoa.Include(p => p.Endereco)
                .Include(p => p.Telefone).AsQueryable();

            query = query.AsNoTracking()
                .OrderBy(p => p.Nome);

            return await query.ToListAsync();
        }

        public async Task<Pessoa> GetPorId(int id)
        {
            IQueryable<Pessoa> query = _context.Pessoa.Include(p => p.Endereco)
                .Include(p => p.Telefone);

            query = query.AsNoTracking()
                .Where(c => c.Id == id);

            return await query.FirstOrDefaultAsync();
        }
    }
}