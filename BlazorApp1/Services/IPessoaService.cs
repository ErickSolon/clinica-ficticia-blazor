using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public interface IPessoaService
    {
        Task Add(Pessoa pessoa);
        Task<List<Pessoa>> GetAll();
        Task<Pessoa> GetById(long id);
        Task Delete(Pessoa pessoa);
        Task Update(Pessoa pessoa);
    }
}
