using CP1_CursoTec.Domain.Entities;

namespace CP1_CursoTec.Domain.Interfaces;

public interface IAulaService
{
    Aula CreateAula(DateTime data, TimeOnly horaInicio, TimeOnly horaFim);

    Aula GetAulaById(Guid id);
}