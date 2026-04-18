using CP1_CursoTec.Domain.Entities;

namespace CP1_CursoTec.Application.Interfaces;

public interface IProfessorRepository
{
    Task<Professor?> GetByIdAsync(Guid id);
    Task<IEnumerable<Professor>> GetAllAsync();
    Task AddAsync(Professor professor);
    Task UpdateAsync(Professor professor);
    void Remove(Professor professor);
}