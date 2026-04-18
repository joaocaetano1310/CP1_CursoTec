using CP1_CursoTec.Domain.Entities;

namespace CP1_CursoTec.Application.Interfaces;

public interface IAulaRepository
{
    Task<Aula?> GetByIdAsync(Guid id);
    Task<IEnumerable<Aula>> GetAllAsync();
    Task AddAsync(Aula aula);
    Task UpdateAsync(Aula aula);
    void Remove(Aula aula);
}