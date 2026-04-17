using CP1_CursoTec.Domain.Entities;

namespace CP1_CursoTec.Application.Interfaces;

/// <summary>
/// Interface do serviço de professores.
/// </summary>
public interface IProfessorService
{
    Professor CreateProfessor(Professor professor);

    Professor? GetById(Guid id);

    Professor? GetByEmail(string email);

    IReadOnlyList<Professor> GetAll();

    Professor UpdateProfessor(Guid id, string? nome, string? email, string? especialidade);

    bool DeactivateProfessor(Guid id);

    bool ActivateProfessor(Guid id);

    bool EmailExists(string email, Guid? excludeId = null);
}