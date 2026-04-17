using CP1_CursoTec.Domain.Entities;

namespace CP1_CursoTec.Application.Interfaces.Repositories;

public interface IAlunoRepository
{
    Task<Aluno?> GetByIdAsync(Guid id);
    Task<IEnumerable<Aluno>> GetAllAsync();
    Task AddAsync(Aluno aluno);
}