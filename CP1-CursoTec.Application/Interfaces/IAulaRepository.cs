using CP1_CursoTec.Domain.Entities;

namespace CP1_CursoTec.Application.Interfaces;

/// <summary>
/// Interface do serviço de aulas.
/// </summary>
public interface IAulaService
{
    Aula CreateAula(Aula aula);

    Aula? GetById(Guid id);

    IReadOnlyList<Aula> GetAll();

    Aula UpdateAula(Guid id, DateTime? data, TimeOnly? horaInicio, TimeOnly? horaFim);

    bool DeleteAula(Guid id);
}