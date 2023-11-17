using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly ProjetoDbContext _context;

        public PessoaService(ProjetoDbContext context)
        {
            _context = context;
        }

        public async Task Add(Pessoa pessoa)
        {
            pessoa.Id = 0;
            await _context.Pessoas.AddAsync(pessoa);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Pessoa>> GetAll()
        {
            var pessoas = await _context.Pessoas.ToListAsync();

            return pessoas;
        }


        public async Task<Pessoa> GetById(long id)
        {
            var resultado = await _context.Pessoas.FirstOrDefaultAsync(dados => dados.Id == id);

            return resultado;
        }

        public async Task Delete(Pessoa pessoa)
        {
            _context.Pessoas.Remove(pessoa);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Pessoa pessoa)
        {
            _context.Pessoas.Update(pessoa);
            await _context.SaveChangesAsync();
        }
    }
}
