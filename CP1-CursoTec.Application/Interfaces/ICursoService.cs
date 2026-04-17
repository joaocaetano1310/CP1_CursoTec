using CP1_CursoTec.Domain.Entities;

namespace CP1_CursoTec.Application.Interfaces;

/// <summary>
/// Interface do serviço de cursos.
/// </summary>
public interface ICursoService
{
    Curso CreateCurso(Curso curso);

    Curso? GetById(Guid id);

    IReadOnlyList<Curso> GetAll();

    Curso UpdateCurso(Guid id, string? nome, int? cargaHoraria, string? descricao);

    bool DeactivateCurso(Guid id);

    bool ActivateCurso(Guid id);
}