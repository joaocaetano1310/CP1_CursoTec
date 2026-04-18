using CP1_CursoTec.Domain.Entities;

namespace CP1_CursoTec.Application.Interfaces;

/// <summary>
/// Interface do serviço de turmas.
/// </summary>
public interface ITurmaService
{
    Turma CreateTurma(Turma turma);

    Turma? GetById(Guid id);

    IReadOnlyList<Turma> GetAll();

    Turma UpdateTurma(Guid id, string? nome, DateTime? dataInicio, DateTime? dataFim);

    bool DeactivateTurma(Guid id);

    bool ActivateTurma(Guid id);
}