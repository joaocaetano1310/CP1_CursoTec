using CP1_CursoTec.Domain.Entities;

namespace CP1_CursoTec.Application.Interfaces.Repositories;

public interface ITurmaRepository
{
    Task<Turma?> GetByIdAsync(Guid id);
    Task<IEnumerable<Turma>> GetAllAsync();
    Task AddAsync(Turma turma);
}