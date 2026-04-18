using CP1_CursoTec.Domain.Entities;

namespace CP1_CursoTec.Application.Interfaces;

public interface ICursoRepository
{
    Task<Curso?> GetByIdAsync(Guid id);
    Task<IEnumerable<Curso>> GetAllAsync();
    Task AddAsync(Curso curso);
    void Update(Curso curso);
    void Remove(Curso curso);
}